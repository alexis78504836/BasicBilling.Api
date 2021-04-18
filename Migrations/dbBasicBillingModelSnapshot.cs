﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BasicBilling.API.Migrations
{
    [DbContext(typeof(dbBasicBilling))]
    partial class dbBasicBillingModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Bills", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClientsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Estado")
                        .HasColumnType("TEXT");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.Property<string>("Periodo")
                        .HasColumnType("TEXT");

                    b.Property<int>("ServicesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("ClientsId");

                    b.HasIndex("ServicesId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("Clients", b =>
                {
                    b.Property<string>("ClientsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("ClientsId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Services", b =>
                {
                    b.Property<int>("ServicesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("ServicesId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Bills", b =>
                {
                    b.HasOne("Clients", "Clients")
                        .WithMany("Bills")
                        .HasForeignKey("ClientsId");

                    b.HasOne("Services", "Services")
                        .WithMany()
                        .HasForeignKey("ServicesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clients");

                    b.Navigation("Services");
                });

            modelBuilder.Entity("Clients", b =>
                {
                    b.Navigation("Bills");
                });
#pragma warning restore 612, 618
        }
    }
}
