using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace AG.Claims.Common
{
    public class DapperRepository
    {
        private readonly string connectionString;

        #region Constructor

        public DapperRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
        }
        public DapperRepository(string connectionStringKey)
        {
            connectionString = ConfigurationManager.ConnectionStrings[connectionStringKey].ConnectionString;
        }

        #endregion

        #region Standard Dapper functionality

        public List<Parent> GetList<Parent, Child>(string query, string splitOn, Func<Parent, Child, Parent> map, object parameters, System.Data.CommandType cmdType)
        {
            using (var connection = GetOpenConnection())
            {
                return connection.Query<Parent, Child, Parent>(query, map, parameters, null, false, splitOn: splitOn, commandType: cmdType).ToList();
            }
        }

        public IEnumerable<T> GetItems<T>(CommandType commandType, string sql, object parameters = null)
        {
            using (var connection = GetOpenConnection())
            {
                return connection.Query<T>(sql, parameters, commandType: commandType);
            }
        }

        /// <summary>
        /// Returns single entity from resultset, default or empty
        /// </summary>
        /// <typeparam name="T">dynamic type</typeparam>
        /// <param name="commandType">text/procedure</param>
        /// <param name="sql">procedure/sql query</param>
        /// <param name="parameters">list of input params</param>
        /// <returns></returns>
        public T GetItem<T>(CommandType commandType, string sql, object parameters = null)
        {
            using (var connection = GetOpenConnection())
            {
                return connection.Query<T>(sql, parameters, commandType: commandType).FirstOrDefault();
            }
        }
        public int Execute(CommandType commandType, string sql, object parameters = null)
        {
            using (var connection = GetOpenConnection())
            {

                return connection.Execute(sql, parameters, commandType: commandType);
            }
        }
        public object ExecuteScalar(CommandType commandType, string sql, object parameters = null)
        {
            using (var connection = GetOpenConnection())
            {
                return connection.ExecuteScalar(sql, parameters, commandType: commandType);

            }
        }

        public SqlConnection GetOpenConnection()
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        #endregion

        #region Automated methods for: Insert, Update, Delete


        // Id column is assumed to be of type int IDENTITY.
        // Key property is determined by convention 
        // (Id, TypeNameId or TypeName_Id) or by custom attribute [DapperKey].
        // All properties with public setters are included. 
        // Exclusion can be manually made with custom attribute [DapperIgnore].
        // If key property is mapped to single database Identity column, 
        // then it is automatically reflected back to object.

        /// <summary>
        /// Automatic generation of SELECT statement, BUT only for simple equality criterias!
        /// For more complex criteria it is necessary to call GetItems method with custom SQL statement.
        /// </summary>
        public IEnumerable<T> Select<T>(object criteria = null)
        {
            var properties = ParseProperties(criteria);
            var sqlPairs = GetSqlPairs(properties.AllNames, " AND ");
            var sql = string.Format("SELECT * FROM [{0}] WHERE {1}", typeof(T).Name, sqlPairs);
            return GetItems<T>(CommandType.Text, sql, properties.AllPairs);
        }

        public void Insert<T>(T obj)
        {
            var propertyContainer = ParseProperties(obj);
            var sql = string.Format(@"INSERT INTO [{0}] ({1}) 
    
                VALUES(@{ 2}) SELECT CAST(scope_identity() AS int)",
                typeof(T).Name,
            string.Join(", ", propertyContainer.ValueNames),
            string.Join(", @", propertyContainer.ValueNames));

            using (var connection = GetOpenConnection())
            {
                var id = connection.Query<int>
                (sql, propertyContainer.ValuePairs, commandType: CommandType.Text).First();
                SetId(obj, id, propertyContainer.IdPairs);
            }
        }

        public void Update<T>(T obj)
        {
            var propertyContainer = ParseProperties(obj);
            var sqlIdPairs = GetSqlPairs(propertyContainer.IdNames);
            var sqlValuePairs = GetSqlPairs(propertyContainer.ValueNames);
            var sql = string.Format(@"UPDATE [{0}] 
    
                SET { 1}
                WHERE { 2}
                ", typeof(T).Name, sqlValuePairs, sqlIdPairs);
            Execute(CommandType.Text, sql, propertyContainer.AllPairs);
        }

        public void Delete<T>(T obj)
        {
            var propertyContainer = ParseProperties(obj);
            var sqlIdPairs = GetSqlPairs(propertyContainer.IdNames);
            var sql = string.Format(@"DELETE FROM [{0}] 
    
                WHERE { 1}
                ", typeof(T).Name, sqlIdPairs);
            Execute(CommandType.Text, sql, propertyContainer.IdPairs);
        }

        #endregion

        #region Reflection support

        /// <summary>
        /// Retrieves a Dictionary with name and value 
        /// for all object properties matching the given criteria.
        /// </summary>
        private static PropertyContainer ParseProperties<T>(T obj)
        {
            var propertyContainer = new PropertyContainer();

            var typeName = typeof(T).Name;
            var validKeyNames = new[] { "Id",
            string.Format("{0}Id", typeName), string.Format("{0}_Id", typeName) };

            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                // Skip reference types (but still include string!)
                if (property.PropertyType.IsClass && property.PropertyType != typeof(string))
                    continue;

                // Skip methods without a public setter
                if (property.GetSetMethod() == null)
                    continue;

                // Skip methods specifically ignored
                if (property.IsDefined(typeof(DapperIgnore), false))
                    continue;

                var name = property.Name;
                var value = typeof(T).GetProperty(property.Name).GetValue(obj, null);

                if (property.IsDefined(typeof(DapperKey), false) || validKeyNames.Contains(name))
                {
                    propertyContainer.AddId(name, value);
                }
                else
                {
                    propertyContainer.AddValue(name, value);
                }
            }

            return propertyContainer;
        }

        /// <summary>
        /// Create a commaseparated list of value pairs on 
        /// the form: "key1=@value1, key2=@value2, ..."
        /// </summary>
        private static string GetSqlPairs
        (IEnumerable<string> keys, string separator = ", ")
        {
            var pairs = keys.Select(key => string.Format("{0}=@{0}", key)).ToList();
            return string.Join(separator, pairs);
        }

        private void SetId<T>(T obj, int id, IDictionary<string, object> propertyPairs)
        {
            if (propertyPairs.Count == 1)
            {
                var propertyName = propertyPairs.Keys.First();
                var propertyInfo = obj.GetType().GetProperty(propertyName);
                if (propertyInfo.PropertyType == typeof(int))
                {
                    propertyInfo.SetValue(obj, id, null);
                }
            }
        }

        #endregion
    }
}
