﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Solution.Core.Interfaces;
using Warehouse.Solution.Domain.Model;
using Warehouse.Solution.Dto;

namespace Warehouse.Solution.Core.Services.Interfaces
{
    public interface IProductService : ITemplateCrud<Producto, ProductoDto>
    {
    }
}
