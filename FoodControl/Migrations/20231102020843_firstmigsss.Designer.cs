﻿// <auto-generated />
using System;
using FoodControl.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodControl.Migrations
{
    [DbContext(typeof(DogtreatmentsContext))]
    [Migration("20231102020843_firstmigsss")]
    partial class firstmigsss
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("FoodControl.Models.Treatment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("Food")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MissingFood")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MissingWater")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Water")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Treatments");
                });
#pragma warning restore 612, 618
        }
    }
}
