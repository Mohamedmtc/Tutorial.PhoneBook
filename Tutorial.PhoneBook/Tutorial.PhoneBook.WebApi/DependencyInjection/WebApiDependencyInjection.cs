using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tutorial.PhoneBook.Application.Contracts;
using Tutorial.PhoneBook.Core.AppSetting;
using Tutorial.PhoneBook.Core.DependencyInjection;
using Tutorial.PhoneBook.Presistance.Context;

namespace Tutorial.PhoneBook.WebApi.DependencyInjection
{
    public static class WebApiDependencyInjection
    {
        public static void AddWebApilayerDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            AddPreLayers(services, configuration);
            AddDataBase(services);   
        }
        private static void AddPreLayers(IServiceCollection services, IConfiguration configuration)
        {
            services.AddCoreLayer(configuration);
        }
        private static void AddDataBase(IServiceCollection services)
        {
            services.AddDbContext<DatabaseService>(opt => opt.UseSqlServer(SettingsDependancyInjection.SqlSettings.ConnectionString!));
            services.AddScoped<IDataBaseService, DatabaseService>();
        }

    }
}
