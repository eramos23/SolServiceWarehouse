using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Solution.Domain.DbContexts;

namespace Warehouse.Solution.Domain
{
    public static class ConfigureDbContext
    {
        public static void ConfigureServices(this IServiceCollection services, string connectionString)
        {
            services.AddEntityFrameworkMySql()
                .AddDbContext<WarehouseDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
        }
    }
}
