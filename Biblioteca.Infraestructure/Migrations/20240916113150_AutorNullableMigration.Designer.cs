﻿// <auto-generated />
using System;
using Biblioteca.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Biblioteca.Infraestructure.Migrations
{
    [DbContext(typeof(BibliotecaDBContext))]
    [Migration("20240916113150_AutorNullableMigration")]
    partial class AutorNullableMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Biblioteca.Core.Models.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("Biblioteca.Core.Models.Libro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AutorId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroPaginas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.ToTable("Libros");
                });

            modelBuilder.Entity("Biblioteca.Core.Models.Libro", b =>
                {
                    b.HasOne("Biblioteca.Core.Models.Autor", "Autor")
                        .WithMany("Libros")
                        .HasForeignKey("AutorId");

                    b.Navigation("Autor");
                });

            modelBuilder.Entity("Biblioteca.Core.Models.Autor", b =>
                {
                    b.Navigation("Libros");
                });
#pragma warning restore 612, 618
        }
    }
}
