using Microsoft.Extensions.DependencyInjection;
using Warehouse.Solution.Core;
using Warehouse.Solution.Core.Interfaces;
using Warehouse.Solution.Core.Services;
using Warehouse.Solution.Core.Services.Interfaces;
using Warehouse.Solution.Domain.DbContexts;
using Warehouse.Solution.Domain.DbContexts.Interface;

namespace Warehouse.Sol.Web.Configuration
{
    public static class CoreServices
    {
        public static void AddCoreServices(this IServiceCollection services)
        {
            services.AddTransient<IDataManager, RepositoryManager>();
            services.AddScoped<IEntidadFinancieraService, EntidadFinancieraService>();
            services.AddScoped<IEmpresaService, EmpresaService>();
            services.AddScoped<IEmpresaSucursalService, EmpresaSucursalService>();
            services.AddScoped<IProviderService, ProviderService>();
        }
    }
}
