﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BasicBilling.API.Migrations
{
    [DbContext(typeof(dbBasicBilling))]
    [Migration("20210418195242_updatefield")]
    partial class updatefield
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

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("Estado")
                        .HasColumnType("TEXT");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.Property<string>("clientId")
                        .HasColumnType("TEXT");

                    b.Property<string>("period")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("clientId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("Client", b =>
                {
                    b.Property<string>("clientId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("clientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Bills", b =>
                {
                    b.HasOne("Client", "Client")
                        .WithMany("Bills")
                        .HasForeignKey("clientId");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Client", b =>
                {
                    b.Navigation("Bills");
                });
#pragma warning restore 612, 618
        }
    }
}