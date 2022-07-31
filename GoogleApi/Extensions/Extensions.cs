using GoogleApi.DBContext.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;


namespace GoogleApi.Extensions
{
    public static class Extensions
    {
        public static void ConfigContext(this IServiceCollection services, IConfiguration configuration)
        {
            /* var Administracion = configuration.GetConnectionString("Administracion");

             services.AddDbContext<ApplicationDbContext>(options =>
             {
                 options.UseMySql(Administracion, ServerVersion.AutoDetect(Administracion),
                            mySqlOptionsAction: sqlOptions =>
                            {
                                sqlOptions.EnableRetryOnFailure(
                                maxRetryCount: 5,
                                maxRetryDelay: TimeSpan.FromSeconds(30),
                                errorNumbersToAdd: null);
                                sqlOptions.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName);
                            }

                        )
                     //.ReplaceService<IUpdateSqlGenerator, MapToProcedureUpdateSqlGenerator>();

                 options.EnableSensitiveDataLogging();
                 options.EnableServiceProviderCaching(true);
                 options.EnableThreadSafetyChecks();
                 options.EnableDetailedErrors();

             }, ServiceLifetime.Transient);*/


            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Defaultdatabase"));
            });
        }
        public static void AddSwagger(this IServiceCollection services)
        {
            // Register the swagger generator, definign one or more Swaggger documents
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "GoogleApi",
                    Version = "v1",
                    Description = @"Servicios de API REST FULLTaylor",
                    TermsOfService = new Uri("https://www.google.com"),
                    Contact = new OpenApiContact() { Name = "Taylor.info", Email = "jhonmontenegro2512@gmail.com" }
                });
                  options.ResolveConflictingActions(apiDescription => apiDescription.First());

                  //Get XML comment path
                  var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                  var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                  var xmlModePath = Path.Combine(AppContext.BaseDirectory, "PRESTTO.PUERTTO.DOMAIN.xml");

                  // Set xml path
                  options.IncludeXmlComments(xmlPath, true);
                  options.IncludeXmlComments(xmlModePath, true);
               //   options.EnableAnnotations();



                  // UseFullTypeNameInSchemaIds replacement for .NET Core
                  //options.CustomSchemaIds(x => x.FullName);
                  // options.ExampleFilters();

                  options.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                
                options.CustomSchemaIds(currentClass =>
                {
                    if (currentClass.IsGenericType && currentClass.Name.Contains("DomainEntityList"))
                    {
                        string returnedValue = $"{currentClass.GenericTypeArguments.First().Name}List";
                        return returnedValue;
                    }
                    return currentClass.Name;
                });

            });
        }
        public static void UseCustomSwagger(this IApplicationBuilder app)
        {
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            app.UseDeveloperExceptionPage();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("../swagger/v1/swagger.json", "Puertto");
            });
        }
    }

    
}
