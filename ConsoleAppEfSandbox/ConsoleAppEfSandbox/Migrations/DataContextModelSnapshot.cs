﻿// <auto-generated />
using System;
using ConsoleAppEfSandbox.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ConsoleAppEfSandbox.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ConsoleAppEfSandbox.Entities.Dts.DataSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.ToTable("data_sets", "dts");
                });

            modelBuilder.Entity("ConsoleAppEfSandbox.Entities.Organizations.DataSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId")
                        .HasDatabaseName("IX_data_sets_CreatedByUserId1");

                    b.ToTable("data_sets", "organizations");
                });

            modelBuilder.Entity("ConsoleAppEfSandbox.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ConsoleAppEfSandbox.Entities.Dts.DataSet", b =>
                {
                    b.HasOne("ConsoleAppEfSandbox.Entities.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreatedByUser");
                });

            modelBuilder.Entity("ConsoleAppEfSandbox.Entities.Organizations.DataSet", b =>
                {
                    b.HasOne("ConsoleAppEfSandbox.Entities.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreatedByUser");
                });
#pragma warning restore 612, 618
        }
    }
}
