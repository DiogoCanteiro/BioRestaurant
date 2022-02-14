using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Bio.Web.Configurations;

namespace Bio.Web.Models
{
    public class ApiRequest
    {
        public APIType APIType { get; set; } = APIType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}
