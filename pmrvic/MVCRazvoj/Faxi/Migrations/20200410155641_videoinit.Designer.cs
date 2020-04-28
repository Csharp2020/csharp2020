﻿// <auto-generated />
using System;
using Faxi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Faxi.Migrations
{
    [DbContext(typeof(videotekaContext))]
    [Migration("20200410155641_videoinit")]
    partial class videoinit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Faxi.Models.Evidencije", b =>
                {
                    b.Property<int>("PrijateljiId")
                        .HasColumnName("prijatelji_id")
                        .HasColumnType("int");

                    b.Property<int>("MedijiId")
                        .HasColumnName("mediji_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumPosudbe")
                        .HasColumnName("datum_posudbe")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DatumVracanja")
                        .HasColumnName("datum_vracanja")
                        .HasColumnType("date");

                    b.HasKey("PrijateljiId", "MedijiId");

                    b.HasIndex("MedijiId");

                    b.ToTable("Evidencije");
                });

            modelBuilder.Entity("Faxi.Models.Mediji", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnName("naziv")
                        .HasColumnType("varchar(120)")
                        .HasMaxLength(120)
                        .IsUnicode(false);

                    b.Property<bool>("Vrsta")
                        .HasColumnName("vrsta")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Mediji");
                });

            modelBuilder.Entity("Faxi.Models.Prijatelji", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnName("ime")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnName("prezime")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Prijatelji");
                });

            modelBuilder.Entity("Faxi.Models.Evidencije", b =>
                {
                    b.HasOne("Faxi.Models.Mediji", "Mediji")
                        .WithMany("Evidencije")
                        .HasForeignKey("MedijiId")
                        .HasConstraintName("FK_Evidencije_Mediji")
                        .IsRequired();

                    b.HasOne("Faxi.Models.Prijatelji", "Prijatelji")
                        .WithMany("Evidencije")
                        .HasForeignKey("PrijateljiId")
                        .HasConstraintName("FK_Evidencije_Prijatelji")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
