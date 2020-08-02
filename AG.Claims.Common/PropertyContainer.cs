using System.Collections.Generic;
using System.Linq;

namespace AG.Claims.Common
{
    public class PropertyContainer
    {
        private readonly Dictionary<string, object> ids;
        private readonly Dictionary<string, object> values;

        #region Properties

        internal IEnumerable<string> IdNames
        {
            get { return ids.Keys; }
        }

        internal IEnumerable<string> ValueNames
        {
            get { return values.Keys; }
        }

        internal IEnumerable<string> AllNames
        {
            get { return ids.Keys.Union(values.Keys); }
        }

        internal IDictionary<string, object> IdPairs
        {
            get { return ids; }
        }

        internal IDictionary<string, object> ValuePairs
        {
            get { return values; }
        }

        internal IEnumerable<KeyValuePair<string, object>> AllPairs
        {
            get { return ids.Concat(values); }
        }

        #endregion

        #region Constructor

        internal PropertyContainer()
        {
            ids = new Dictionary<string, object>();
            values = new Dictionary<string, object>();
        }

        #endregion

        #region Methods

        internal void AddId(string name, object value)
        {
            ids.Add(name, value);
        }

        internal void AddValue(string name, object value)
        {
            values.Add(name, value);
        }

        #endregion
    }
}
