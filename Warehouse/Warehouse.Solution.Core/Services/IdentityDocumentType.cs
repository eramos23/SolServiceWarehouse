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
    public class IdentityDocumentType : IIdentityDocumentType
    {
        private readonly IDataManager _dataManager;
        public IdentityDocumentType(IDataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public async Task<IEnumerable<TipoDocumentoIdentidad>> GetAllAsync()
        {
            return await _dataManager.TipoDocumentoIdentidadRepository.GetAll();
        }

        public Task<TipoDocumentoIdentidad> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
