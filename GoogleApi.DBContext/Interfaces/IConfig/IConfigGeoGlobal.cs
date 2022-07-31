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
        IEntityTypeConfiguration<bounds>
       /* IEntityTypeConfiguration<Cordenadas_location>,
        IEntityTypeConfiguration<Cordenadas_southwest>,
        IEntityTypeConfiguration<Cordenadas_northeast>*/
    {
    }
}
