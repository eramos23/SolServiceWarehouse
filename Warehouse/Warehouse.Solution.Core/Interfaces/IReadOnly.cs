using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Core.Interfaces
{
    public interface IReadOnly<T>
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(string id);

    }
}
