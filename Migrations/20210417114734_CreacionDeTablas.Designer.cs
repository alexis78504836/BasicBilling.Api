﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BasicBilling.API.Migrations
{
    [DbContext(typeof(dbBasicBilling))]
    [Migration("20210417114734_CreacionDeTablas")]
    partial class CreacionDeTablas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Bills", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Estado")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Monto")
                        .HasColumnType("TEXT");

                    b.Property<string>("Periodo")
                        .HasColumnType("TEXT");

                    b.Property<string>("clientsID")
                        .HasColumnType("TEXT");

                    b.Property<int?>("servicesID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("clientsID");

                    b.HasIndex("servicesID");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("Clients", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Services", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Bills", b =>
                {
                    b.HasOne("Clients", "clients")
                        .WithMany()
                        .HasForeignKey("clientsID");

                    b.HasOne("Services", "services")
                        .WithMany()
                        .HasForeignKey("servicesID");

                    b.Navigation("clients");

                    b.Navigation("services");
                });
#pragma warning restore 612, 618
        }
    }
}