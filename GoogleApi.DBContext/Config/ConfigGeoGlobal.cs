using GoogleApi.DBContext.Interfaces.IConfig;
using GoogleApi.DBContext.Parameter;
using GoogleApi.Domain.Entities.Geoglobal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.DBContext.Config
{
    internal class ConfigGeoGlobal : IConfigGeoGlobal
    {
        public void Configure(EntityTypeBuilder<Cordenadas> builder)
        {
            builder.ToTable(Table.tbl_cordenada.ToString());
            builder.Property(e => e.latitud).IsUnicode(true);
            builder.Property(e => e.Longitud).IsUnicode(true);
           /* builder.HasOne(e => e.Cordenadas_northeast).WithOne(e => e.Cordenadas).HasForeignKey<Cordenadas_northeast>(e => e.Id_Cordenadas);
            builder.HasOne(e => e.Cordenadas_southwest).WithOne(e => e.Cordenadas).HasForeignKey<Cordenadas_southwest>(e => e.Id_Cordenadas);
            builder.HasOne(e => e.Cordenadas_location).WithOne(e => e.Cordenadas).HasForeignKey<Cordenadas_location>(e => e.Id_Cordenadas);*/
        }

        public void Configure(EntityTypeBuilder<bounds> builder)
        {
            builder.ToTable(Table.tbl_bounds.ToString());
            builder.HasOne(e => e.northeast).WithOne(e => e.northeast).HasForeignKey<bounds>(e => e.Id_northeast).HasConstraintName($"FK_{Table.tbl_bounds}_{Table.tbl_cordenada}")
    .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.southwest).WithOne(e => e.southwest).HasForeignKey<bounds>(e => e.Id_southwest).HasConstraintName($"FK_{Table.tbl_bounds}_{Table.tbl_southwest}2")
    .OnDelete(DeleteBehavior.Restrict);

        }

        public void Configure(EntityTypeBuilder<geometry> builder)
        {
            builder.ToTable(Table.tbl_geometry.ToString());
            builder.HasOne(e => e.bounds).WithOne(e => e.geometry).HasForeignKey<geometry>(e => e.Id_bounds).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.location).WithOne(e => e.geometry).HasForeignKey<geometry>(e => e.Id_location).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.location_Type).WithMany(e => e.geometry).HasForeignKey(e => e.Id_location_type).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.viewport).WithOne(e => e.viewport).HasForeignKey<geometry>(e => e.Id_viewport).OnDelete(DeleteBehavior.Restrict);
        }

        public void Configure(EntityTypeBuilder<GoogleAdress_tiene_types> builder)
        {
            builder.ToTable(Table.tbl_google_adress_tiene_types.ToString());
            builder.HasKey(e => new { e.Id_GoogleAdress, e.Id_GoogleAdress_types });
            builder.HasOne(e=>e.GoogleAdress_types).WithMany(e=>e.GoogleAdress_tiene_types).HasForeignKey(e=>e.Id_GoogleAdress_types);
            builder.HasOne(e=>e.GoogleAdress).WithMany(e=>e.types).HasForeignKey(e=>e.Id_GoogleAdress);
        }

        public void Configure(EntityTypeBuilder<GoogleAdress> builder)
        {
            builder.ToTable(Table.tbl_google_adress.ToString());
            builder.HasOne(e => e.plus_code).WithOne(e => e.GoogleAdress).HasForeignKey<GoogleAdress>(e => e.Id_plus_code).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.geometry).WithOne(e => e.GoogleAdress).HasForeignKey<GoogleAdress>(e => e.Id_geometry).OnDelete(DeleteBehavior.Restrict);
        }

        public void Configure(EntityTypeBuilder<address_components_and_GoogleAdressType> builder)
        {
            builder.ToTable(Table.tbl_google_adress_tiene_types.ToString());
        }
        /*
public void Configure(EntityTypeBuilder<Cordenadas_location> builder)
{
builder.ToTable(Table.tbl_location.ToString());
}

public void Configure(EntityTypeBuilder<Cordenadas_southwest> builder)
{
builder.ToTable(Table.tbl_southwest.ToString());
}

public void Configure(EntityTypeBuilder<Cordenadas_northeast> builder)
{
builder.ToTable(Table.tbl_northeast.ToString());
}
*/
    }
}
