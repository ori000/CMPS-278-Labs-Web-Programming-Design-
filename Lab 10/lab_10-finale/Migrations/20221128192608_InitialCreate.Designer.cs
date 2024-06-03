﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using lab_10_finale_ori00.Data;

#nullable disable

namespace lab_10_finale_ori00.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221128192608_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.11");

            modelBuilder.Entity("lab_10_finale_ori00.Models.Hotel", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("imgURL")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("rating")
                        .HasColumnType("INTEGER");

                    b.Property<int>("rooms")
                        .HasColumnType("INTEGER");

                    b.HasKey("name");

                    b.ToTable("Hotel");

                    b.HasData(
                        new
                        {
                            name = "Hotel_1",
                            description = "D1",
                            imgURL = "",
                            location = "Beirut",
                            phone = "1921",
                            rating = 4,
                            rooms = 100
                        },
                        new
                        {
                            name = "Hotel_2",
                            description = "D2",
                            imgURL = "",
                            location = "Jaffa",
                            phone = "2121",
                            rating = 5,
                            rooms = 200
                        },
                        new
                        {
                            name = "Hotel_3",
                            description = "D3",
                            imgURL = "",
                            location = "Nicosia",
                            phone = "3221",
                            rating = 5,
                            rooms = 220
                        },
                        new
                        {
                            name = "Hotel_4",
                            description = "D4",
                            imgURL = "",
                            location = "Alexandria",
                            phone = "2221",
                            rating = 5,
                            rooms = 420
                        });
                });
#pragma warning restore 612, 618
        }
    }
}