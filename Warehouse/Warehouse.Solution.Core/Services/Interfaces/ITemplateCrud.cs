using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Core.Interfaces
{
    public interface ITemplateCrud<MODEL,DTO>
    {
        Task<List<MODEL>> GetAllAsync(DTO filterDto);
        Task<MODEL> GetByIdAsync(Guid id);

        Task<bool> UpdateAsync(Guid id, MODEL model);

        Task<bool> CrateAsync(MODEL model);

        Task<bool> DeleteAsync(Guid id);

    }
}
