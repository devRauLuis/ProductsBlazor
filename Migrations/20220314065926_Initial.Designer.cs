﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Raul_Luis_Ap2_p2a.DAL;

#nullable disable

namespace Raul_Luis_Ap2_p2a.Migrations
{
    [DbContext(typeof(ProductsContext))]
    [Migration("20220314065926_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("Raul_Luis_Ap2_p2a.Entidades.PDPUtilizados", b =>
                {
                    b.Property<int>("PDPUtilizadosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CantidadUtilizada")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProductoDetallesId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProductosEmpacadosId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PDPUtilizadosId");

                    b.HasIndex("ProductoDetallesId");

                    b.HasIndex("ProductosEmpacadosId");

                    b.ToTable("PDPUtilizados");
                });

            modelBuilder.Entity("Raul_Luis_Ap2_p2a.Entidades.ProductoDetalles", b =>
                {
                    b.Property<int>("ProductoDetallesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float?>("Cantidad")
                        .HasColumnType("REAL");

                    b.Property<float?>("Peso")
                        .HasColumnType("REAL");

                    b.Property<float?>("Precio")
                        .HasColumnType("REAL");

                    b.Property<string>("Presentacion")
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductoDetallesId");

                    b.HasIndex("ProductoId");

                    b.ToTable("ProductoDetalles");
                });

            modelBuilder.Entity("Raul_Luis_Ap2_p2a.Entidades.ProductoDetallesPresentacion", b =>
                {
                    b.Property<int?>("ProductoDetallesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float?>("Cantidad")
                        .HasColumnType("REAL");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<float?>("ExistenciaEmpacada")
                        .HasColumnType("REAL");

                    b.Property<float?>("Peso")
                        .HasColumnType("REAL");

                    b.Property<float?>("Precio")
                        .HasColumnType("REAL");

                    b.Property<string>("Presentacion")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductoDetallesId");

                    b.ToView("ProductoDetallesPresentacion");
                });

            modelBuilder.Entity("Raul_Luis_Ap2_p2a.Entidades.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float?>("Costo")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int?>("Existencia")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("FechaExpiracion")
                        .HasColumnType("TEXT");

                    b.Property<float?>("Ganancia")
                        .HasColumnType("REAL");

                    b.Property<float?>("Peso")
                        .HasColumnType("REAL");

                    b.Property<float?>("Precio")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.Property<float?>("ValorInventario")
                        .HasColumnType("REAL");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Raul_Luis_Ap2_p2a.Entidades.ProductosEmpacados", b =>
                {
                    b.Property<int?>("ProductosEmpacadosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Concepto")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Fecha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProducidoProductoDetallesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductosEmpacadosId");

                    b.HasIndex("ProducidoProductoDetallesId");

                    b.ToTable("ProductosEmpacados");
                });

            modelBuilder.Entity("Raul_Luis_Ap2_p2a.Entidades.PDPUtilizados", b =>
                {
                    b.HasOne("Raul_Luis_Ap2_p2a.Entidades.ProductoDetalles", "ProductoDetalles")
                        .WithMany()
                        .HasForeignKey("ProductoDetallesId");

                    b.HasOne("Raul_Luis_Ap2_p2a.Entidades.ProductosEmpacados", null)
                        .WithMany("Utilizados")
                        .HasForeignKey("ProductosEmpacadosId");

                    b.Navigation("ProductoDetalles");
                });

            modelBuilder.Entity("Raul_Luis_Ap2_p2a.Entidades.ProductoDetalles", b =>
                {
                    b.HasOne("Raul_Luis_Ap2_p2a.Entidades.Productos", "Producto")
                        .WithMany("ProductoDetalles")
                        .HasForeignKey("ProductoId");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Raul_Luis_Ap2_p2a.Entidades.ProductosEmpacados", b =>
                {
                    b.HasOne("Raul_Luis_Ap2_p2a.Entidades.ProductoDetalles", "Producido")
                        .WithMany()
                        .HasForeignKey("ProducidoProductoDetallesId");

                    b.Navigation("Producido");
                });

            modelBuilder.Entity("Raul_Luis_Ap2_p2a.Entidades.Productos", b =>
                {
                    b.Navigation("ProductoDetalles");
                });

            modelBuilder.Entity("Raul_Luis_Ap2_p2a.Entidades.ProductosEmpacados", b =>
                {
                    b.Navigation("Utilizados");
                });
#pragma warning restore 612, 618
        }
    }
}
