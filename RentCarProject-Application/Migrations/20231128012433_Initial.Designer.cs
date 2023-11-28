﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentCarProject_Application.Data;

#nullable disable

namespace RentCarProject_Application.Migrations
{
    [DbContext(typeof(RentCarDBContext))]
    [Migration("20231128012433_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RentCarProject.Domain.Entities.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LessorId")
                        .HasColumnType("int");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RenterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LessorId");

                    b.HasIndex("RenterId")
                        .IsUnique();

                    b.ToTable("cars");
                });

            modelBuilder.Entity("RentCarProject.Domain.Entities.Models.Lessor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("lessor");
                });

            modelBuilder.Entity("RentCarProject.Domain.Entities.Models.Renter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("renter");
                });

            modelBuilder.Entity("RentCarProject.Domain.Entities.Models.Car", b =>
                {
                    b.HasOne("RentCarProject.Domain.Entities.Models.Lessor", "Lessor")
                        .WithMany("Cars")
                        .HasForeignKey("LessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentCarProject.Domain.Entities.Models.Renter", "Renter")
                        .WithOne("Cars")
                        .HasForeignKey("RentCarProject.Domain.Entities.Models.Car", "RenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lessor");

                    b.Navigation("Renter");
                });

            modelBuilder.Entity("RentCarProject.Domain.Entities.Models.Lessor", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("RentCarProject.Domain.Entities.Models.Renter", b =>
                {
                    b.Navigation("Cars")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}