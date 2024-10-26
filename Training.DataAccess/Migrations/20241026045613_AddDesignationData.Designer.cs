﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Training.DataAccess;

#nullable disable

namespace Training.DataAccess.Migrations
{
    [DbContext(typeof(TrainingDbContext))]
    [Migration("20241026045613_AddDesignationData")]
    partial class AddDesignationData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Trainingtask.Models.Entity.Department", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("id");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("isdeleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("upby")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("upby");

                    b.HasKey("Id")
                        .HasName("pk_departments");

                    b.ToTable("departments", (string)null);
                });

            modelBuilder.Entity("Trainingtask.Models.Entity.Designation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("id");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("isdeleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("upby")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("upby");

                    b.HasKey("Id")
                        .HasName("pk_designations");

                    b.ToTable("designations", (string)null);
                });

            modelBuilder.Entity("Trainingtask.Models.Entity.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("city");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<string>("DeptId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("deptid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("isdeleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone");

                    b.Property<string>("upby")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("upby");

                    b.HasKey("Id")
                        .HasName("pk_employees");

                    b.HasIndex("DeptId")
                        .HasDatabaseName("ix_employees_deptid");

                    b.ToTable("employees", (string)null);
                });

            modelBuilder.Entity("Trainingtask.Models.Entity.Employee", b =>
                {
                    b.HasOne("Trainingtask.Models.Entity.Department", "Dept")
                        .WithMany()
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_employees_departments_deptid");

                    b.Navigation("Dept");
                });
#pragma warning restore 612, 618
        }
    }
}
