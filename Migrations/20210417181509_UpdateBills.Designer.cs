﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BasicBilling.API.Migrations
{
    [DbContext(typeof(dbBasicBilling))]
    [Migration("20210417181509_UpdateBills")]
    partial class UpdateBills
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

                    b.Property<string>("ClienteID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Estado")
                        .HasColumnType("TEXT");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.Property<string>("Periodo")
                        .HasColumnType("TEXT");

                    b.Property<int>("ServicesID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("clientsID")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("ServicesID");

                    b.HasIndex("clientsID");

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
                    b.HasOne("Services", "services")
                        .WithMany()
                        .HasForeignKey("ServicesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clients", "clients")
                        .WithMany("Bills")
                        .HasForeignKey("clientsID");

                    b.Navigation("clients");

                    b.Navigation("services");
                });

            modelBuilder.Entity("Clients", b =>
                {
                    b.Navigation("Bills");
                });
#pragma warning restore 612, 618
        }
    }
}