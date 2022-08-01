
using GoogleApi.DBContext.Context;
using GoogleApi.Domain.Entities.Geoglobal;
using GoogleApi.Domain.Parameters;
using GoogleApi.pplication.Dtos.GoogleEncoding;
using GoogleApi.pplication.Dtos.GoogleGlobal;
using GoogleApi.pplication.Inferfaces.GlobalAdressService;
using GoogleApi.Repository;
using GoogleApi.Repository.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.pplication.AppServices.GlobalAdresServices
{
    public class GlobalAdressServicio : IGlobalAdressServicio
    {
        private  IExtensionRepository extensionRepository;
        private  ApplicationDbContext dbContext;

        public GlobalAdressServicio(IExtensionRepository extensionRepository, ApplicationDbContext dbContext)
        {
            this.extensionRepository = extensionRepository;
            this.dbContext = dbContext;
        }

        public async Task<GobalAdress> Post(CordenadasDto entidad)
        {
            CultureInfo culture = new CultureInfo("en-US");
            HttpContent content;
            string url = "https://maps.googleapis.com/maps/api/geocode/json?latlng={Latitud},{Longitud}&sensor=true&key={apiKey}";
            string apiKey = "AIzaSyCz9I2ZBKcQf1x6D4lxlP1xi-PErtn-WgY";
            string placeid = "GhIJej3zzZFQAUARdPv2v-37U8A";
            url = url.Replace("{Latitud}", entidad.latitud.ToString(culture)).Replace("{Longitud}", entidad.Longitud.ToString(culture)).Replace("{apiKey}", apiKey);
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);
            content = response.Content;
            var a = await content.ReadAsStringAsync();
            var contenido = JsonConvert.DeserializeObject<GoogleEncodingDto>(a);
            GobalAdress gobalAdress = new GobalAdress
            {
                plus_Code = extensionRepository.mapper.Map<plus_code>(contenido.plus_code),

            };
            gobalAdress.GobalAdress_and_GoogleAdress = new List<GobalAdress_and_GoogleAdress>();
          await  contenido.results.ForEachAsync(async e =>
            {
                GobalAdress_and_GoogleAdress gobalAdress_And_GoogleAdress = new GobalAdress_and_GoogleAdress();
                gobalAdress_And_GoogleAdress.GoogleAdress = new GoogleAdress();
                gobalAdress_And_GoogleAdress.GoogleAdress.place_id = e.place_id;
                gobalAdress_And_GoogleAdress.GoogleAdress.formatted_address = e.formatted_address;
                gobalAdress_And_GoogleAdress.GoogleAdress.plus_code = extensionRepository.mapper.Map<plus_code>(e.plus_code);
                gobalAdress_And_GoogleAdress.GoogleAdress.geometry = extensionRepository.mapper.Map<geometry>(e.geometry);

                gobalAdress_And_GoogleAdress.GoogleAdress.GoogleAdress_and_address_components = new List<GoogleAdress_and_address_components>();
                
                
                gobalAdress_And_GoogleAdress.GoogleAdress.geometry.location_Types = new location_type();
                gobalAdress_And_GoogleAdress.GoogleAdress.geometry.location_Types.Name = e.geometry.location_type;


                gobalAdress_And_GoogleAdress.GoogleAdress.types = new List<GoogleAdress_tiene_types>();
             await   e.types.ForEachAsync(async types =>
                {
                    GoogleAdress_tiene_types googleAdress_Types = new GoogleAdress_tiene_types();

                    googleAdress_Types.GoogleAdress_types = new GoogleAdress_types(); ;
                    googleAdress_Types.GoogleAdress_types.Name= types;
                    gobalAdress_And_GoogleAdress.GoogleAdress.types.Add(googleAdress_Types);
                });
                await e.address_Components.ForEachAsync(async address_components =>
                {
                    GoogleAdress_and_address_components GoogleAdress_and_address_components = new GoogleAdress_and_address_components();
                    GoogleAdress_and_address_components.address_Components = extensionRepository.mapper.Map<address_components>(address_components);
                    GoogleAdress_and_address_components.address_Components.address_components_and_GoogleAdressType = new List<address_components_and_GoogleAdressType>();
                 await   address_components.types.ForEachAsync( async types => {
                        address_components_and_GoogleAdressType typo = new address_components_and_GoogleAdressType();
                        typo.GoogleAdress_types = new GoogleAdress_types();
                        typo.GoogleAdress_types.Name = types;
                        GoogleAdress_and_address_components.address_Components.address_components_and_GoogleAdressType.Add(typo);
                    });
                    gobalAdress_And_GoogleAdress.GoogleAdress.GoogleAdress_and_address_components.Add(GoogleAdress_and_address_components);

                });

           
                gobalAdress.GobalAdress_and_GoogleAdress.Add(gobalAdress_And_GoogleAdress);
            });
            await gobalAdress.GobalAdress_and_GoogleAdress.ForEachAsync(async e =>
            {
                if (e.GoogleAdress.geometry.bounds != null)
                {
                  e.GoogleAdress.geometry.bounds.northeast=   await extensionRepository.repositorioCordenadas.Post(e.GoogleAdress.geometry.bounds.northeast);
                    e.GoogleAdress.geometry.bounds.Id_northeast = e.GoogleAdress.geometry.bounds.northeast.Id;
                    e.GoogleAdress.geometry.bounds.northeast = null;
                    e.GoogleAdress.geometry.bounds.southwest= await extensionRepository.repositorioCordenadas.Post(e.GoogleAdress.geometry.bounds.southwest);
                    e.GoogleAdress.geometry.bounds.Id_southwest = e.GoogleAdress.geometry.bounds.southwest.Id;
                    e.GoogleAdress.geometry.bounds.southwest = null;
                    if (e.GoogleAdress.geometry.location != null)
                    {
                        e.GoogleAdress.geometry.location= await extensionRepository.repositorioCordenadas.Post(e.GoogleAdress.geometry.location);
                        e.GoogleAdress.geometry.Id_location = e.GoogleAdress.geometry.location.Id;
                        e.GoogleAdress.geometry.location = null;
                    }
                }

                if (e.GoogleAdress.geometry.location_Types != null)
                {

                }
                if (e.GoogleAdress.geometry.viewport != null)
                {
                    e.GoogleAdress.geometry.viewport.northeast = await extensionRepository.repositorioCordenadas.Post(e.GoogleAdress.geometry.viewport.northeast);
                    e.GoogleAdress.geometry.viewport.Id_northeast = e.GoogleAdress.geometry.viewport.northeast.Id;
                    e.GoogleAdress.geometry.viewport.northeast= null;
                    e.GoogleAdress.geometry.viewport.southwest = await extensionRepository.repositorioCordenadas.Post(e.GoogleAdress.geometry.viewport.southwest);
                    e.GoogleAdress.geometry.viewport.Id_southwest = e.GoogleAdress.geometry.viewport.southwest.Id;
                    e.GoogleAdress.geometry.viewport.southwest = null;
                }


            });
            gobalAdress = await extensionRepository.repositoryGlobalAdress.Post(gobalAdress);
            return gobalAdress;
        }
    }
}
