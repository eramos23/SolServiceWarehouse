using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Domain.DbContexts.Interface
{
    public interface IDataManager
    {
        WarehouseDbContext DbContext { get; }
    }
}
