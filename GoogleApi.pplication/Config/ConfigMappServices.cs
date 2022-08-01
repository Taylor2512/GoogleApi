using AutoMapper;
using GoogleApi.Domain.Entities.Geoglobal;
using GoogleApi.pplication.Dtos.GoogleEncoding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.pplication.Config
{
    public class ConfigMappServices : Profile
    {
        public ConfigMappServices()
        {
            CreateMap<GoogleEncodingDto, GobalAdress>()
                .ReverseMap();
            CreateMap<plus_codeDto, plus_code>()
                .ReverseMap();
            CreateMap<GoogleAdressDto, GoogleAdress>()

                .ReverseMap();
            CreateMap<geometry,Google_geometryDto>()
                  .ReverseMap();  
            CreateMap<Google_boundsDto, bounds>()
                .ReverseMap();
            CreateMap<Google_cordenadasDto, Cordenadas>()
            .ForMember(e => e.latitud, y => y.MapFrom(ex=>ex.lat))
            .ForMember(e => e.Longitud, y => y.MapFrom(ex=>ex.lng))
                .ReverseMap();
            CreateMap<Google_geometryDto,location_type>()
    
                .ReverseMap();
            CreateMap<address_components, Google_address_componentsDto>()
      //.ForMember(e => e.types, y => y.Ignore())
                .ReverseMap();
        }
    }
}
