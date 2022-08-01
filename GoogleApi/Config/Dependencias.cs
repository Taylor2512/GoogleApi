using GoogleApi.Extensions;
using GoogleApi.pplication.Config;
using GoogleApi.Repository.Config;

namespace GoogleApi.Config
{
    public static class Dependencias
    {
        public static void InyectarDependencias(this WebApplicationBuilder builder)
        {
            builder.Services.ConfigContext(builder.Configuration);
            builder.Services.InyectarRepositorios();
            builder.Services.InyectarAppsServices();
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
