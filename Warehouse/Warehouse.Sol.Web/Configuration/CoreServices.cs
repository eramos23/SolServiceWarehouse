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
            services.AddScoped<IFinancialEntityService, FinancialEntityService>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<ICompanyBranchService, CompanyBranchService>();
            services.AddScoped<IProviderService, ProviderService>();
            services.AddScoped<IIdentityDocumentType, IdentityDocumentType>();
            services.AddScoped<IProductCategoryService, ProductCategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductUseService, ProductUseService>();
            services.AddScoped<IProductUnitMeasureService, ProductUnitMeasureService>();
            services.AddScoped<IProductBrandService, ProductBrandService>();
            services.AddScoped<ILaboratoryService, LaboratoryService>();

        }
    }
}
