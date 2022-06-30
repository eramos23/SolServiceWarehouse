using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Core.Interfaces
{
    public interface ICrud<T>
    {
        Task<List<T>> GetAllAsync(T filtroDto);
        Task<T> GetByIdAsync(int id);

        Task<bool> UpdateAsync(int id, T model);

        Task<bool> CrateAsync(T model);

        Task<bool> DeleteAsync(int id);

    }
}
