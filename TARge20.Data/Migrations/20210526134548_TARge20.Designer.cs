﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TARge20.Data;

namespace TARge20.Data.Migrations
{
    [DbContext(typeof(TARge20DbContext))]
    [Migration("20210526134548_TARge20")]
    partial class TARge20
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TARge20.Core.Domain.Ametinimetus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nimetus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Ametinimetus");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Children", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Eesnimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Isikukood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Perekonnanimi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Children");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Aadress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Isikukood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kontakttelefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TöölAlates")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Ettepanek", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Ettepanek");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Firma", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Aadress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("HarukontorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kontaktisik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistriNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HarukontorId");

                    b.ToTable("Firma");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Haigusleht", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Algus")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Lõpp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Haigusleht");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Harukontor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Aadress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kontaktisik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TöötamineId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TöötamineId");

                    b.ToTable("Harukontor");
                });

            modelBuilder.Entity("TARge20.Core.Domain.LaenutatavAsi", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Algus")
                        .HasColumnType("datetime2");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("LaenutusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Lõpp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LaenutusId");

                    b.ToTable("LaenutatavAsi");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Laenutus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Laenutus");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Ligipääs", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Ligipääs");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Puhkus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Puhkus");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Puhkuseliik", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Algus")
                        .HasColumnType("datetime2");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Lõpp")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("PuhkusId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PuhkusId");

                    b.ToTable("Puhkuseliik");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Tervisekontroll", b =>
                {
                    b.Property<Guid>("TervisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Kuupäev")
                        .HasColumnType("datetime2");

                    b.HasKey("TervisId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Tervisekontroll");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Töötamine", b =>
                {
                    b.Property<Guid>("TöötamineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Alates")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("AmetinimetusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Kuni")
                        .HasColumnType("datetime2");

                    b.HasKey("TöötamineId");

                    b.HasIndex("AmetinimetusId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Töötamine");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Vihjed", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FirmaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vihje")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FirmaId");

                    b.ToTable("Vihjed");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Ametinimetus", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany("Ametinimetuss")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Children", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany("Childrens")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Ettepanek", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany("Ettepaneks")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Firma", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Harukontor", null)
                        .WithMany("Firmas")
                        .HasForeignKey("HarukontorId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Haigusleht", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany("Haiguslehtss")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Harukontor", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Töötamine", null)
                        .WithMany("Harukontors")
                        .HasForeignKey("TöötamineId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.LaenutatavAsi", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Laenutus", "Laenutus")
                        .WithMany("LaenutatavAsis")
                        .HasForeignKey("LaenutusId");

                    b.Navigation("Laenutus");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Laenutus", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany("Laenutuss")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Ligipääs", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany("Ligipääss")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Puhkus", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany("Puhkuss")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Puhkuseliik", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Puhkus", null)
                        .WithMany("Puhkuseliiks")
                        .HasForeignKey("PuhkusId");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Tervisekontroll", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany("Tervisekontrolls")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Töötamine", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Ametinimetus", "Ametinimetus")
                        .WithMany()
                        .HasForeignKey("AmetinimetusId");

                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany("Töötamines")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Ametinimetus");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Vihjed", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Firma", "Firma")
                        .WithMany("Vihjeds")
                        .HasForeignKey("FirmaId");

                    b.Navigation("Firma");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Employee", b =>
                {
                    b.Navigation("Ametinimetuss");

                    b.Navigation("Childrens");

                    b.Navigation("Ettepaneks");

                    b.Navigation("Haiguslehtss");

                    b.Navigation("Laenutuss");

                    b.Navigation("Ligipääss");

                    b.Navigation("Puhkuss");

                    b.Navigation("Tervisekontrolls");

                    b.Navigation("Töötamines");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Firma", b =>
                {
                    b.Navigation("Vihjeds");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Harukontor", b =>
                {
                    b.Navigation("Firmas");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Laenutus", b =>
                {
                    b.Navigation("LaenutatavAsis");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Puhkus", b =>
                {
                    b.Navigation("Puhkuseliiks");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Töötamine", b =>
                {
                    b.Navigation("Harukontors");
                });
#pragma warning restore 612, 618
        }
    }
}
