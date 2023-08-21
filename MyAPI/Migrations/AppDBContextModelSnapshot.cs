﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyAPI.DataContext;

#nullable disable

namespace MyAPI.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyAPI.Models.DSR", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BNo")
                        .HasColumnType("int");

                    b.Property<string>("BType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CashAmt")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CreditAmt")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<decimal>("UPIAmt")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("DSRs");
                });
#pragma warning restore 612, 618
        }
    }
}
