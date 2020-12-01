﻿// <auto-generated />
using System;
using MascotasApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MascotasApp.Migrations
{
    [DbContext(typeof(MascotaContext))]
    partial class MascotaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MascotasApp.Models.Mascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DescripcionFisica")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescripcionPersonalidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreTemporal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TipoMascotaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoMascotaId");

                    b.ToTable("Mascotas");
                });

            modelBuilder.Entity("MascotasApp.Models.TipoMascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("TiempoVidaPromedio")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.ToTable("TipoMascotas");
                });

            modelBuilder.Entity("MascotasApp.Models.Mascota", b =>
                {
                    b.HasOne("MascotasApp.Models.TipoMascota", "Tipo")
                        .WithMany("Mascotas")
                        .HasForeignKey("TipoMascotaId");

                    b.Navigation("Tipo");
                });

            modelBuilder.Entity("MascotasApp.Models.TipoMascota", b =>
                {
                    b.Navigation("Mascotas");
                });
#pragma warning restore 612, 618
        }
    }
}
