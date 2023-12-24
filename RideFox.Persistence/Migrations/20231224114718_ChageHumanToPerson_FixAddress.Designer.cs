﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RideFox.Persistence;

#nullable disable

namespace RideFox.Persistence.Migrations
{
    [DbContext(typeof(RideFoxDbContext))]
    [Migration("20231224114718_ChageHumanToPerson_FixAddress")]
    partial class ChageHumanToPerson_FixAddress
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RideFox.Domain.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Build")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("character varying(120)");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Address");
                });

            modelBuilder.Entity("RideFox.Domain.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uuid");

                    b.Property<int>("RentCount")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("RideFox.Domain.Parking", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Parking");
                });

            modelBuilder.Entity("RideFox.Domain.Path", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("FromId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("PathLength")
                        .HasColumnType("numeric");

                    b.Property<Guid>("ToId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("FromId");

                    b.HasIndex("ToId");

                    b.ToTable("Path");
                });

            modelBuilder.Entity("RideFox.Domain.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("PaymentLink")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<DateTime?>("TimePayment")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("PaymentLink")
                        .IsUnique();

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("RideFox.Domain.Penalty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("character varying(600)");

                    b.Property<string>("InspectorFIO")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("MVDAddressId")
                        .HasColumnType("uuid");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("ClientId");

                    b.HasIndex("Link")
                        .IsUnique();

                    b.HasIndex("MVDAddressId");

                    b.ToTable("Penalty");
                });

            modelBuilder.Entity("RideFox.Domain.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateOfRegister")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("RideFox.Domain.Rent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("End")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("PathId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PaymentId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ScooterId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Start")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("PathId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("ScooterId");

                    b.ToTable("Rent");
                });

            modelBuilder.Entity("RideFox.Domain.Scooter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateOfCommissioning")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<Guid?>("ParkingId")
                        .HasColumnType("uuid");

                    b.Property<string>("ScooterName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ParkingId");

                    b.HasIndex("ScooterName")
                        .IsUnique();

                    b.ToTable("Scooter");
                });

            modelBuilder.Entity("RideFox.Domain.Service", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("character varying(600)");

                    b.Property<DateTime>("End")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ScooterId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("StaffId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Start")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ScooterId");

                    b.HasIndex("StaffId");

                    b.ToTable("Sevice");
                });

            modelBuilder.Entity("RideFox.Domain.Staff", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ClientId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uuid");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("PersonId");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("RideFox.Domain.Client", b =>
                {
                    b.HasOne("RideFox.Domain.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("RideFox.Domain.Parking", b =>
                {
                    b.HasOne("RideFox.Domain.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("RideFox.Domain.Path", b =>
                {
                    b.HasOne("RideFox.Domain.Parking", "From")
                        .WithMany()
                        .HasForeignKey("FromId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RideFox.Domain.Parking", "To")
                        .WithMany()
                        .HasForeignKey("ToId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("From");

                    b.Navigation("To");
                });

            modelBuilder.Entity("RideFox.Domain.Penalty", b =>
                {
                    b.HasOne("RideFox.Domain.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RideFox.Domain.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RideFox.Domain.Address", "MVDAddress")
                        .WithMany()
                        .HasForeignKey("MVDAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Client");

                    b.Navigation("MVDAddress");
                });

            modelBuilder.Entity("RideFox.Domain.Rent", b =>
                {
                    b.HasOne("RideFox.Domain.Client", "Client")
                        .WithMany("Rents")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RideFox.Domain.Path", "Path")
                        .WithMany()
                        .HasForeignKey("PathId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RideFox.Domain.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RideFox.Domain.Scooter", "Scooter")
                        .WithMany("Rents")
                        .HasForeignKey("ScooterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Path");

                    b.Navigation("Payment");

                    b.Navigation("Scooter");
                });

            modelBuilder.Entity("RideFox.Domain.Scooter", b =>
                {
                    b.HasOne("RideFox.Domain.Parking", null)
                        .WithMany("Scooters")
                        .HasForeignKey("ParkingId");
                });

            modelBuilder.Entity("RideFox.Domain.Service", b =>
                {
                    b.HasOne("RideFox.Domain.Scooter", "Scooter")
                        .WithMany("Services")
                        .HasForeignKey("ScooterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RideFox.Domain.Staff", "Staff")
                        .WithMany("Services")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Scooter");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("RideFox.Domain.Staff", b =>
                {
                    b.HasOne("RideFox.Domain.Client", null)
                        .WithMany("Penalties")
                        .HasForeignKey("ClientId");

                    b.HasOne("RideFox.Domain.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("RideFox.Domain.Client", b =>
                {
                    b.Navigation("Penalties");

                    b.Navigation("Rents");
                });

            modelBuilder.Entity("RideFox.Domain.Parking", b =>
                {
                    b.Navigation("Scooters");
                });

            modelBuilder.Entity("RideFox.Domain.Scooter", b =>
                {
                    b.Navigation("Rents");

                    b.Navigation("Services");
                });

            modelBuilder.Entity("RideFox.Domain.Staff", b =>
                {
                    b.Navigation("Services");
                });
#pragma warning restore 612, 618
        }
    }
}
