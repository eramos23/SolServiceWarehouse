using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Solution.Core.Interfaces;
using Warehouse.Solution.Domain.Model;

namespace Warehouse.Solution.Core.Services.Interfaces
{
    public interface IIdentityDocumentType : ITemplateReadOnly<TipoDocumentoIdentidad>
    {
    }
}
