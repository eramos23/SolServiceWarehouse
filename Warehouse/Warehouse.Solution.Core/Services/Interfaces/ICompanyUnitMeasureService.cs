using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Solution.Core.Interfaces;
using Warehouse.Solution.Domain.Model;
using Warehouse.Solution.Dto;
using Warehouse.Solution.Dto.Filters;
using Warehouse.Solution.Dto.PersonalizedResponse;

namespace Warehouse.Solution.Core.Services.Interfaces
{
    public interface ICompanyUnitMeasureService : ITemplateCrud<EmpresaUnidadMedida, Filter>
    {
        Task<List<UnidadMedidaEmpresaDto>> GetAllPersonalizedAsync(Filter filterDto);
    }
}
