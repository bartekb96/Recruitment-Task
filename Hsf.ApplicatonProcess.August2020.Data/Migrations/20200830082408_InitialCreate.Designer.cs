﻿// <auto-generated />
using Hsf.ApplicatonProcess.August2020.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hsf.ApplicatonProcess.August2020.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200830082408_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hsf.ApplicatonProcess.August2020.Domain.Applicant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CountryOfOrigin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMailAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Hired")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Applicants");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "Kalinowa 26",
                            Age = 24,
                            CountryOfOrigin = "Poland",
                            EMailAdress = "bartekbednarek@gmail.com",
                            FamilyName = "Bednarek",
                            Hired = false,
                            Name = "Bartosz"
                        },
                        new
                        {
                            ID = 2,
                            Address = "Kwiatowa 22",
                            Age = 40,
                            CountryOfOrigin = "Poland",
                            EMailAdress = "mariuszpudzianowski@gmail.com",
                            FamilyName = "Pudzianowski",
                            Hired = true,
                            Name = "Mariusz"
                        },
                        new
                        {
                            ID = 3,
                            Address = "Wielka Krokwia 35",
                            Age = 39,
                            CountryOfOrigin = "Poland",
                            EMailAdress = "adammalysz@gmail.com",
                            FamilyName = "Malysz",
                            Hired = true,
                            Name = "Adam"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
