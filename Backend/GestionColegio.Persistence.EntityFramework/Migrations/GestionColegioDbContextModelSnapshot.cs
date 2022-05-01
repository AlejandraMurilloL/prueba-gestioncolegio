﻿// <auto-generated />
using System;
using GestionColegio.Persistence.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestionColegio.Persistence.EntityFramework.Migrations
{
    [DbContext(typeof(GestionColegioDbContext))]
    partial class GestionColegioDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GestionColegio.Domain.Entities.Asignatura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProfesorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfesorId");

                    b.ToTable("Asignaturas");
                });

            modelBuilder.Entity("GestionColegio.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Usuario");
                });

            modelBuilder.Entity("GestionColegio.Domain.Entities.Estudiante", b =>
                {
                    b.HasBaseType("GestionColegio.Domain.Entities.Usuario");

                    b.HasDiscriminator().HasValue("Estudiante");
                });

            modelBuilder.Entity("GestionColegio.Domain.Entities.Profesor", b =>
                {
                    b.HasBaseType("GestionColegio.Domain.Entities.Usuario");

                    b.HasDiscriminator().HasValue("Profesor");
                });

            modelBuilder.Entity("GestionColegio.Domain.Entities.Asignatura", b =>
                {
                    b.HasOne("GestionColegio.Domain.Entities.Profesor", null)
                        .WithMany("Asignaturas")
                        .HasForeignKey("ProfesorId");
                });
#pragma warning restore 612, 618
        }
    }
}
