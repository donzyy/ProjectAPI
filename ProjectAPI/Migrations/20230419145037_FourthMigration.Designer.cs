﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectAPI.DatabaseContext;

namespace ProjectAPI.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20230419145037_FourthMigration")]
    partial class FourthMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectAPI.Model.Computer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("computerLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("computerNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Computers");
                });

            modelBuilder.Entity("ProjectAPI.Model.Department", b =>
                {
                    b.Property<int>("Department_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Department_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Department_ID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ProjectAPI.Model.Driver", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("salesMan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("truck")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("ProjectAPI.Model.Employee", b =>
                {
                    b.Property<int>("Employee_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Department_ID")
                        .HasColumnType("int");

                    b.Property<string>("Employee_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Employee_Birth_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Employee_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employee_First_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Employee_Hire_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Employee_Last_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Employee_Phone_Number")
                        .HasColumnType("int");

                    b.Property<double>("Employee_Salary")
                        .HasColumnType("float");

                    b.Property<DateTime>("Employee_Status")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Employee_Termination_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Position_ID")
                        .HasColumnType("int");

                    b.HasKey("Employee_ID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ProjectAPI.Model.Login", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("ProjectAPI.Model.Position", b =>
                {
                    b.Property<int>("Position_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Position_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Position_ID");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("ProjectAPI.Model.Register", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Registration");
                });

            modelBuilder.Entity("ProjectAPI.Model.Sales", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PercentageChange")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalSales")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("ProjectAPI.Model.Truck", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("dailySales")
                        .HasColumnType("int");

                    b.Property<int>("dispenserBottlePrice")
                        .HasColumnType("int");

                    b.Property<int>("dispenserBottlesRemaining")
                        .HasColumnType("int");

                    b.Property<int>("dispenserBottlesSold")
                        .HasColumnType("int");

                    b.Property<int>("dispenserBottlesTaken")
                        .HasColumnType("int");

                    b.Property<string>("registrationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sachetBagPrice")
                        .HasColumnType("int");

                    b.Property<int>("sachetBagsSold")
                        .HasColumnType("int");

                    b.Property<int>("sachetBagsTaken")
                        .HasColumnType("int");

                    b.Property<int>("sachetRemaining")
                        .HasColumnType("int");

                    b.Property<string>("truckDriver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("truckSalesMan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trucks");
                });
#pragma warning restore 612, 618
        }
    }
}
