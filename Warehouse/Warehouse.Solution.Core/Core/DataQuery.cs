using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Core.Core
{
    public class DataQuery<T>
    {
        public HttpStatusCode apiStatus { get; set; }
        public string apiMessage { get; set; }
        public T data { get; set; }
        public int total { get; set; }

        public DataQuery(T data)
        {
            apiStatus = HttpStatusCode.OK;
            apiMessage = string.Empty;
            this.data = data;
        }

        public DataQuery(T data, string apiStatus, string apiMessage)
        {
            this.apiStatus = HttpStatusCode.OK;
            this.apiMessage = apiMessage;
            this.data = data;
            total = 0;
        }

    }
}
