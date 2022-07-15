﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Solution.Core.Interfaces;
using Warehouse.Solution.Domain.DbContexts;
using Warehouse.Solution.Domain.DbContexts.Interface;
using Warehouse.Solution.Domain.Model;

namespace Warehouse.Solution.Core
{
    public class FinancialEntityService : IFinancialEntityService
    {
        private readonly WarehouseDbContext _dataManager;

        public FinancialEntityService(WarehouseDbContext dataManager)
        {
            _dataManager = dataManager;
        }

        public async Task<IEnumerable<EntidadFinanciera>> GetAllAsync()
        {
            return  _dataManager.EntidadFinanciera.ToList();
        }

        public Task<EntidadFinanciera> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
