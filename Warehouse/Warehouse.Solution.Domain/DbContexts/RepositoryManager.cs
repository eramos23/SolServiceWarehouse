using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Solution.Domain.DbContexts.Interface;

namespace Warehouse.Solution.Domain.DbContexts
{
    public class RepositoryManager : IDataManager
    {
        private readonly WarehouseDbContext Context;
        public WarehouseDbContext DbContext => this.Context;
    }
}
