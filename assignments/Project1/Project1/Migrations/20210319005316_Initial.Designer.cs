﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project1.Models;

namespace Project1.Migrations
{
    [DbContext(typeof(TripContext))]
    [Migration("20210319005316_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Project1.Models.Trip", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Accommodation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccommodationEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccommodationPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2(7)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2(7)");

                    b.Property<string>("ThingToDo1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThingToDo2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThingToDo3")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TripId");

                    b.ToTable("Trips");

                    b.HasData(
                        new
                        {
                            TripId = 1,
                            Destination = "Boise",
                            EndDate = new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ThingToDo1 = "Visit Tammy"
                        },
                        new
                        {
                            TripId = 2,
                            Accommodation = "The Benson Hotel",
                            AccommodationEmail = "staff@bensonhotel.com",
                            AccommodationPhone = "503-555-1234",
                            Destination = "Portland",
                            EndDate = new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ThingToDo1 = "Go To Voodoo Doughnuts",
                            ThingToDo2 = "Walk in the rain",
                            ThingToDo3 = "Go to Powell"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
