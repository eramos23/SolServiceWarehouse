using System.Collections;
using Warehouse.Solution.Core.Core;

namespace Warehouse.Sol.Web.Helper
{
    public class HelperStatus
    {
        public static DataQuery<T> ResponseHelper<T>(T data, string status , string message = "")
        {
            return new DataQuery<T>(data)
            {
                data = data,
                apiMessage = message,
                apiStatus = status,
                total = (data as ICollection).Count
            };
        }
    }
}
