﻿// <auto-generated />
using System;
using GoogleApi.DBContext.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GoogleApi.DBContext.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220731031034_1")]
    partial class _1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GoogleApi.Domain.Entities.Geoglobal.Cordenadas", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Longitud")
                        .IsUnicode(true)
                        .HasColumnType("float");

                    b.Property<double>("latitud")
                        .IsUnicode(true)
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("tbl_cordenada", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}