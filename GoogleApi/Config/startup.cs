using GoogleApi.Extensions;
using GoogleApi.pplication.Config;
using GoogleApi.Repository.Config;
using Microsoft.AspNetCore.HttpOverrides;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace GoogleApi.Config
{
    public static class startup
    {
        public static WebApplication Inicializar(this String[] args)
        {

            var builder = WebApplication.CreateBuilder(args);


            builder.ConfigureServices();

            var app = builder.Build();
            Configure(app);

            return app;

        }
        public static void ConfigureServices(this WebApplicationBuilder builder)
        {

            builder.Services.AddControllers();
           // builder.Inyections();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.InyectarDependencias();
            builder.Services.AddControllers()
              .AddNewtonsoftJson(options =>
              {
                  options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                  options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

                  options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;

              })
              .AddJsonOptions(options =>
              {
                  options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                  options.JsonSerializerOptions.WriteIndented = true;
                  options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
                  options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
              });

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("Alltodo",
                                  builder =>
                                  {
                                      builder.AllowAnyHeader();
                                      builder.AllowAnyMethod();
                                      builder.AllowAnyOrigin();


                                  });
            });


            builder.Services.AddMvc();


            /*       builder.Services.AddControllers().AddJsonOptions(options =>
                   {
                       options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                       options.JsonSerializerOptions.IgnoreNullValues = true;
                   });

                   */


        }

        private static void Configure(WebApplication app)
        {

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseHsts();

            }
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseCookiePolicy();
            //app.UseDeveloperExceptionPage();
            app.UseCors("Alltodo");
            app.UseDeveloperExceptionPage();

            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            // app.UseSession();
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor |
          ForwardedHeaders.XForwardedProto
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
