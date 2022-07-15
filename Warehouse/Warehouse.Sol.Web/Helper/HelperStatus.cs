using System.Collections;
using System.Net;
using Warehouse.Solution.Core.Core;

namespace Warehouse.Sol.Web.Helper
{
    public class HelperStatus
    {
        public static DataQuery<T> ResponseHelper<T>(T data, HttpStatusCode status = HttpStatusCode.OK, string message = "")
        {
            return new DataQuery<T>(data)
            {
                data = data,
                apiMessage = message,
                apiStatus = status,
                total = data is ICollection ? (data as ICollection).Count : 0
            };
        }
    }
}
