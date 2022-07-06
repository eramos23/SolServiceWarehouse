using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Solution.Core.Services.Interfaces;
using Warehouse.Solution.Domain.DbContexts;
using Warehouse.Solution.Domain.DbContexts.Interface;
using Warehouse.Solution.Domain.Model;

namespace Warehouse.Solution.Core.Services
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IDataManager _dataManager;
        public EmpresaService(IDataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public async Task<IEnumerable<Empresa>> GetAllAsync()
        {
            return await _dataManager.EmpresaRepository.GetAll();
        }

        public async Task<Empresa> GetByIdAsync(string id)
        {
            var company = await _dataManager.EmpresaRepository.FirstOrDefault(c => c.Id == new Guid(id));
            return company;
        }
    }
}
