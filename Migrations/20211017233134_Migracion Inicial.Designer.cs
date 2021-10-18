﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RolesConPermisos.DAL;

namespace RolesConPermisos.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20211017233134_Migracion Inicial")]
    partial class MigracionInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("RolesConPermisos.Entidades.Permisos", b =>
                {
                    b.Property<int>("PermisoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("PermisoID");

                    b.ToTable("Permisos");
                });

            modelBuilder.Entity("RolesConPermisos.Entidades.Roles", b =>
                {
                    b.Property<int>("RolID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<bool>("esActivo")
                        .HasColumnType("INTEGER");

                    b.HasKey("RolID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("RolesConPermisos.Entidades.RolesDetalles", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PermisoID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RolID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("esAsignado")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("PermisoID");

                    b.HasIndex("RolID");

                    b.ToTable("RolesDetalles");
                });

            modelBuilder.Entity("RolesConPermisos.Entidades.RolesDetalles", b =>
                {
                    b.HasOne("RolesConPermisos.Entidades.Permisos", null)
                        .WithMany("Detalle")
                        .HasForeignKey("PermisoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RolesConPermisos.Entidades.Roles", null)
                        .WithMany("RolesDetalle")
                        .HasForeignKey("RolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RolesConPermisos.Entidades.Permisos", b =>
                {
                    b.Navigation("Detalle");
                });

            modelBuilder.Entity("RolesConPermisos.Entidades.Roles", b =>
                {
                    b.Navigation("RolesDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}