using GoogleApi.Domain.Entities.Geoglobal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.DBContext.Interfaces.IConfig
{
    internal interface IConfigGeoGlobal: 
        IEntityTypeConfiguration<Cordenadas>,
        IEntityTypeConfiguration<geometry>,
        IEntityTypeConfiguration<GoogleAdress>,
        IEntityTypeConfiguration<address_components_and_GoogleAdressType>,
        IEntityTypeConfiguration<GoogleAdress_tiene_types>,
     //   IEntityTypeConfiguration<location_type_and_geometry>,
        IEntityTypeConfiguration<GobalAdress>,
        IEntityTypeConfiguration<GoogleAdress_and_address_components>,
        IEntityTypeConfiguration<GobalAdress_and_GoogleAdress>,
        IEntityTypeConfiguration<bounds>

    {
    }
}
