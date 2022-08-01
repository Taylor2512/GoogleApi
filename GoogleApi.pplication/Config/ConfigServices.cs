using GoogleApi.pplication.AppServices;
using GoogleApi.pplication.AppServices.GlobalAdresServices;
using GoogleApi.pplication.Inferfaces;
using GoogleApi.pplication.Inferfaces.GlobalAdressService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.pplication.Config
{
     public  static class ConfigServices
    {
        public static void InyectarAppsServices(this IServiceCollection services)
        {
            services.AddScoped<IGlobalAdressServicio, GlobalAdressServicio>();
            services.AddScoped<IEnxtensionServices, ExtensionServices>();
        }
    }
}
