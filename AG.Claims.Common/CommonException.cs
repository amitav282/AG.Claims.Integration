using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AG.Claims.Common
{
   
    public class CommonException : Exception
    {
        public CommonException(string message) : base(message)
        {
        }
    }
}
