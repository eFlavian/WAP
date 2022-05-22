﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PROJECT___WAP.Entities;

#nullable disable

namespace PROJECT___WAP.Migrations.Shipping
{
    [DbContext(typeof(ShippingContext))]
    partial class ShippingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("PROJECT___WAP.Entities.Shipping", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Payment")
                        .HasColumnType("REAL");

                    b.Property<string>("StartingPoint")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Vehicle")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Shippings");
                });
#pragma warning restore 612, 618
        }
    }
}
