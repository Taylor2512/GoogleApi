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
            builder.HasOne(e => e.location_Types).WithMany(e => e.geometry).HasForeignKey(e => e.Id_location_type).OnDelete(DeleteBehavior.Restrict);
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
            builder.ToTable(Table.tbl_address_components_and_GoogleAdressType.ToString());
            builder.HasKey(e => new { e.Id_GoogleAdress_types, e.Id_address_components });
            builder.HasOne(e => e.GoogleAdress_types).WithMany(e => e.address_components_and_GoogleAdressType).HasForeignKey(e => e.Id_GoogleAdress_types);
            builder.HasOne(e => e.address_components).WithMany(e => e.address_components_and_GoogleAdressType).HasForeignKey(e => e.Id_address_components);


        }

        public void Configure(EntityTypeBuilder<GobalAdress> builder)
        {
            builder.ToTable(Table.tbl_GobalAdress.ToString());
            builder.HasOne(e => e.plus_Code).WithOne(e => e.GobalAdress).HasForeignKey<GobalAdress>(e => e.Id_plus_code);

        }

        public void Configure(EntityTypeBuilder<GoogleAdress_and_address_components> builder)
        {
            builder.ToTable(Table.tbl_GoogleAdress_and_address_components.ToString());
            builder.HasKey(e => new { e.Id_GoogleAdress, e.Id_address_components });
            builder.HasOne(e => e.address_Components).WithMany(e => e.GoogleAdress_and_address_components).HasForeignKey(e => e.Id_address_components);
            builder.HasOne(e => e.GoogleAdress).WithMany(e => e.GoogleAdress_and_address_components).HasForeignKey(e => e.Id_GoogleAdress);

        }

        public void Configure(EntityTypeBuilder<GobalAdress_and_GoogleAdress> builder)
        {
            builder.ToTable(Table.tbl_GobalAdress_and_GoogleAdress.ToString());
            builder.HasKey(e => new { e.Id_GoogleAdress, e.Id_GobalAdress });
            builder.HasOne(e => e.GobalAdress).WithMany(e => e.GobalAdress_and_GoogleAdress).HasForeignKey(e => e.Id_GobalAdress);
            builder.HasOne(e => e.GoogleAdress).WithMany(e => e.GobalAdress_and_GoogleAdress).HasForeignKey(e => e.Id_GoogleAdress);


        }
    }
}
