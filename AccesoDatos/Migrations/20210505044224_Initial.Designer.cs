﻿// <auto-generated />
using System;
using Infraestructura;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infraestructura.Migrations
{
    [DbContext(typeof(ConectionMySql))]
    [Migration("20210505044224_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Dominio.Entities.Book", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("author")
                        .HasColumnType("longtext");

                    b.Property<bool>("read")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("title")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Dominio.Entities.User", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("address")
                        .HasColumnType("longtext");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<string>("firstName")
                        .HasColumnType("longtext");

                    b.Property<string>("lastName")
                        .HasColumnType("longtext");

                    b.Property<string>("password")
                        .HasColumnType("longtext");

                    b.Property<string>("phone")
                        .HasColumnType("longtext");

                    b.Property<string>("userName")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
