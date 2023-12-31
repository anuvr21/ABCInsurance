﻿// <auto-generated />
using System;
using InsuranceApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InsuranceApp.Migrations
{
    [DbContext(typeof(DataDBContext))]
    [Migration("20230918133045_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InsuranceApp.Model.Member", b =>
                {
                    b.Property<string>("UNIQUEPERSONKEY")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DATEOFBIRTH")
                        .HasColumnType("datetime2");

                    b.Property<string>("EMAIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FIRSTNAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GENDER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LASTNAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MIDDLEINITIAL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PERMANENTADDRESSLINE1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PERMANENTADDRESSLINE2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PERMANENTCITY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PERMANENTCOUNTY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PERMANENTSTATE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PERMANENTZIPCODE")
                        .HasColumnType("int");

                    b.Property<string>("TELEPHONENUMBER")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UNIQUEPERSONKEY");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("InsuranceApp.Model.Pharmacy", b =>
                {
                    b.Property<string>("MEMBERNUMBER")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PROVIDERID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QUANTITY")
                        .HasColumnType("int");

                    b.Property<int?>("RXDAYSSUPPLY")
                        .HasColumnType("int");

                    b.Property<int?>("RXFILLDATE")
                        .HasColumnType("int");

                    b.Property<string>("UNITSOFMEASURE")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MEMBERNUMBER");

                    b.ToTable("Pharmacy");
                });

            modelBuilder.Entity("InsuranceApp.Model.Provider", b =>
                {
                    b.Property<string>("PROVIDERID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CONTRACTED")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FIRSTNAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HPSPECIALITYCODE1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LASTNAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MIDDLEINITIAL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PAYORID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TAXONOMYCODE1")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PROVIDERID");

                    b.ToTable("Provider");
                });
#pragma warning restore 612, 618
        }
    }
}
