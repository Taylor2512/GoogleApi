using GoogleApi.Repository.Interfaces;
using GoogleApi.Repository.Repository.GoogleRepository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.Repository.Config
{
    public static class Dependencias
    {
        public static void InyectarRepositorios(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryGlobalAdress,RepositoryGlobalAdress>();
            services.AddScoped< IRepositoriobounds ,Repositoriobounds> ();
            services.AddScoped<IExtensionRepository,ExtensionRepository>();
            services.AddScoped<IRepositorioCordenadas , RepositorioCordenadas> ();
            //services.AddScoped<IExtensionRepository>();

        }
    }
}
