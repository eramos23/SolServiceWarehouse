using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Core.Core
{
    public class DataQuery<T>
    {
        public string apiStatus { get; set; }
        public string apiMessage { get; set; }
        public T data { get; set; }
        public int total { get; set; }

        public DataQuery(T data)
        {
            apiStatus = Status.Ok;
            apiMessage = string.Empty;
            this.data = data;
            total = 0;
        }

        public DataQuery(T data, string apiStatus, string apiMessage)
        {
            this.apiStatus = apiStatus;
            this.apiMessage = apiMessage;
            this.data = data;
            total = 0;
        }

    }
}
