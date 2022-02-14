using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Web
{
    public static class Configurations
    {
        public static string ProductApiBase { get; set; }
        public enum APIType
        {
            GET,
            PUT,
            POST,
            DELETE
        }
    }
}
