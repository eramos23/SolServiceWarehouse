using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Solution.Core.Services.Interfaces;
using Warehouse.Solution.Domain.DbContexts.Interface;
using Warehouse.Solution.Domain.Model;

namespace Warehouse.Solution.Core.Services
{
    public class CompanyBranchService : ICompanyBranchService
    {
        private readonly IDataManager _dataManager;
        public CompanyBranchService(IDataManager dataManager)
        {
            _dataManager = dataManager;
        }
        public async Task<IEnumerable<EmpresaSucursal>> GetAllAsync()
        {
            return await _dataManager.EmpresaSucursalRepository.GetAll();
        }

        public async Task<IEnumerable<EmpresaSucursal>> GetAllByIdCompanyAsync(string idCompany)
        {
            return await _dataManager.EmpresaSucursalRepository.GetQueryable().Where(c => c.IdEmpresa == new Guid(idCompany)).ToListAsync();
        }

        public Task<EmpresaSucursal> GetByIdAsync(string id)
        {
            return _dataManager.EmpresaSucursalRepository.FirstOrDefault(c => c.IdEmpresa == new Guid(id));
        }
    }
}
