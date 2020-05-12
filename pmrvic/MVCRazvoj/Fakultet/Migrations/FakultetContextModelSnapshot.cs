﻿// <auto-generated />
using System;
using Fakultet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fakultet.Migrations
{
    [DbContext(typeof(FakultetContext))]
    partial class FakultetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fakultet.Models.Dvorana", b =>
                {
                    b.Property<string>("OznDvorana")
                        .HasColumnName("oznDvorana")
                        .HasColumnType("char(5)")
                        .IsFixedLength(true)
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<int?>("Kapacitet")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("kapacitet")
                        .HasColumnType("int")
                        .HasDefaultValueSql("((40))");

                    b.HasKey("OznDvorana");

                    b.HasIndex("OznDvorana")
                        .IsUnique()
                        .HasName("dvoranaUnique");

                    b.ToTable("dvorana");
                });

            modelBuilder.Entity("Fakultet.Models.Ispit", b =>
                {
                    b.Property<DateTime>("DatIspit")
                        .HasColumnName("datIspit")
                        .HasColumnType("datetime");

                    b.Property<int>("MbrStud")
                        .HasColumnName("mbrStud")
                        .HasColumnType("int");

                    b.Property<short>("Ocjena")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ocjena")
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("SifNastavnik")
                        .HasColumnName("sifNastavnik")
                        .HasColumnType("int");

                    b.Property<int>("SifPred")
                        .HasColumnName("sifPred")
                        .HasColumnType("int");

                    b.HasIndex("MbrStud");

                    b.HasIndex("SifNastavnik");

                    b.HasIndex("SifPred");

                    b.ToTable("ispit");
                });

            modelBuilder.Entity("Fakultet.Models.Mjesto", b =>
                {
                    b.Property<int>("Pbr")
                        .HasColumnName("pbr")
                        .HasColumnType("int");

                    b.Property<string>("NazMjesto")
                        .IsRequired()
                        .HasColumnName("nazMjesto")
                        .HasColumnType("nchar(40)")
                        .IsFixedLength(true)
                        .HasMaxLength(40);

                    b.Property<short?>("SifZupanija")
                        .HasColumnName("sifZupanija")
                        .HasColumnType("smallint");

                    b.HasKey("Pbr");

                    b.HasIndex("NazMjesto")
                        .HasName("mjestoUnique");

                    b.HasIndex("Pbr")
                        .IsUnique()
                        .HasName("mjestoPbr");

                    b.HasIndex("SifZupanija");

                    b.ToTable("mjesto");
                });

            modelBuilder.Entity("Fakultet.Models.Nastavnik", b =>
                {
                    b.Property<int>("SifNastavnik")
                        .HasColumnName("sifNastavnik")
                        .HasColumnType("int");

                    b.Property<string>("ImeNastavnik")
                        .IsRequired()
                        .HasColumnName("imeNastavnik")
                        .HasColumnType("nchar(25)")
                        .IsFixedLength(true)
                        .HasMaxLength(25);

                    b.Property<decimal>("Koef")
                        .HasColumnName("koef")
                        .HasColumnType("decimal(3, 2)");

                    b.Property<int>("PbrStan")
                        .HasColumnName("pbrStan")
                        .HasColumnType("int");

                    b.Property<string>("PrezNastavnik")
                        .IsRequired()
                        .HasColumnName("prezNastavnik")
                        .HasColumnType("nchar(25)")
                        .IsFixedLength(true)
                        .HasMaxLength(25);

                    b.Property<int>("SifOrgjed")
                        .HasColumnName("sifOrgjed")
                        .HasColumnType("int");

                    b.HasKey("SifNastavnik");

                    b.HasIndex("PbrStan");

                    b.HasIndex("SifNastavnik")
                        .IsUnique()
                        .HasName("nastavnikUnique");

                    b.HasIndex("SifOrgjed");

                    b.ToTable("nastavnik");
                });

            modelBuilder.Entity("Fakultet.Models.Orgjed", b =>
                {
                    b.Property<int>("SifOrgjed")
                        .HasColumnName("sifOrgjed")
                        .HasColumnType("int");

                    b.Property<string>("NazOrgjed")
                        .IsRequired()
                        .HasColumnName("nazOrgjed")
                        .HasColumnType("nchar(60)")
                        .IsFixedLength(true)
                        .HasMaxLength(60);

                    b.Property<int?>("SifNadorgjed")
                        .HasColumnName("sifNadorgjed")
                        .HasColumnType("int");

                    b.HasKey("SifOrgjed");

                    b.HasIndex("SifNadorgjed");

                    b.HasIndex("SifOrgjed")
                        .IsUnique()
                        .HasName("orgjedUnique");

                    b.ToTable("orgjed");
                });

            modelBuilder.Entity("Fakultet.Models.Pred", b =>
                {
                    b.Property<int>("SifPred")
                        .HasColumnName("sifPred")
                        .HasColumnType("int");

                    b.Property<int?>("BrojSatiTjedno")
                        .HasColumnName("brojSatiTjedno")
                        .HasColumnType("int");

                    b.Property<string>("KratPred")
                        .HasColumnName("kratPred")
                        .HasColumnType("char(8)")
                        .IsFixedLength(true)
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<string>("NazPred")
                        .IsRequired()
                        .HasColumnName("nazPred")
                        .HasColumnType("nchar(60)")
                        .IsFixedLength(true)
                        .HasMaxLength(60);

                    b.Property<int?>("SifOrgjed")
                        .HasColumnName("sifOrgjed")
                        .HasColumnType("int");

                    b.Property<int?>("UpisanoStud")
                        .HasColumnName("upisanoStud")
                        .HasColumnType("int");

                    b.HasKey("SifPred");

                    b.HasIndex("SifOrgjed");

                    b.HasIndex("SifPred")
                        .IsUnique()
                        .HasName("predUnique");

                    b.ToTable("pred");
                });

            modelBuilder.Entity("Fakultet.Models.PredNastavnik", b =>
                {
                    b.Property<int>("SifNastavnik")
                        .HasColumnType("int");

                    b.Property<int>("SifPred")
                        .HasColumnType("int");

                    b.HasKey("SifNastavnik", "SifPred");

                    b.HasIndex("SifPred");

                    b.ToTable("pred_nastavnik");
                });

            modelBuilder.Entity("Fakultet.Models.Rezervacija", b =>
                {
                    b.Property<string>("OznDvorana")
                        .IsRequired()
                        .HasColumnName("oznDvorana")
                        .HasColumnType("char(5)")
                        .IsFixedLength(true)
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("OznVrstaDan")
                        .IsRequired()
                        .HasColumnName("oznVrstaDan")
                        .HasColumnType("char(2)")
                        .IsFixedLength(true)
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    b.Property<short>("Sat")
                        .HasColumnName("sat")
                        .HasColumnType("smallint");

                    b.Property<int>("SifPred")
                        .HasColumnName("sifPred")
                        .HasColumnType("int");

                    b.HasIndex("OznDvorana");

                    b.HasIndex("SifPred");

                    b.ToTable("rezervacija");
                });

            modelBuilder.Entity("Fakultet.Models.Stud", b =>
                {
                    b.Property<int>("MbrStud")
                        .HasColumnName("mbrStud")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DatRodStud")
                        .HasColumnName("datRodStud")
                        .HasColumnType("datetime");

                    b.Property<string>("ImeStud")
                        .IsRequired()
                        .HasColumnName("imeStud")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("JmbgStud")
                        .HasColumnName("jmbgStud")
                        .HasColumnType("char(13)")
                        .IsFixedLength(true)
                        .HasMaxLength(13)
                        .IsUnicode(false);

                    b.Property<int?>("PbrRod")
                        .HasColumnName("pbrRod")
                        .HasColumnType("int");

                    b.Property<int>("PbrStan")
                        .HasColumnName("pbrStan")
                        .HasColumnType("int");

                    b.Property<string>("PrezStud")
                        .IsRequired()
                        .HasColumnName("prezStud")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("MbrStud");

                    b.HasIndex("MbrStud")
                        .IsUnique()
                        .HasName("studUnique");

                    b.HasIndex("PbrRod");

                    b.HasIndex("PbrStan");

                    b.ToTable("stud");
                });

            modelBuilder.Entity("Fakultet.Models.Zupanija", b =>
                {
                    b.Property<short>("SifZupanija")
                        .HasColumnName("sifZupanija")
                        .HasColumnType("smallint");

                    b.Property<string>("NazZupanija")
                        .IsRequired()
                        .HasColumnName("nazZupanija")
                        .HasColumnType("nchar(40)")
                        .IsFixedLength(true)
                        .HasMaxLength(40);

                    b.HasKey("SifZupanija");

                    b.HasIndex("SifZupanija")
                        .IsUnique()
                        .HasName("zupanijaUnique");

                    b.ToTable("zupanija");
                });

            modelBuilder.Entity("Fakultet.Models.Ispit", b =>
                {
                    b.HasOne("Fakultet.Models.Stud", "MbrStudNavigation")
                        .WithMany()
                        .HasForeignKey("MbrStud")
                        .HasConstraintName("FK_ispit_stud")
                        .IsRequired();

                    b.HasOne("Fakultet.Models.Nastavnik", "SifNastavnikNavigation")
                        .WithMany()
                        .HasForeignKey("SifNastavnik")
                        .HasConstraintName("FK_ispit_nastavnik")
                        .IsRequired();

                    b.HasOne("Fakultet.Models.Pred", "SifPredNavigation")
                        .WithMany()
                        .HasForeignKey("SifPred")
                        .HasConstraintName("FK_ispit_pred")
                        .IsRequired();
                });

            modelBuilder.Entity("Fakultet.Models.Mjesto", b =>
                {
                    b.HasOne("Fakultet.Models.Zupanija", "SifZupanijaNavigation")
                        .WithMany("Mjesto")
                        .HasForeignKey("SifZupanija")
                        .HasConstraintName("FK_mjesto_zupanija");
                });

            modelBuilder.Entity("Fakultet.Models.Nastavnik", b =>
                {
                    b.HasOne("Fakultet.Models.Mjesto", "PbrStanNavigation")
                        .WithMany("Nastavnik")
                        .HasForeignKey("PbrStan")
                        .HasConstraintName("FK_nastavnik_mjesto")
                        .IsRequired();

                    b.HasOne("Fakultet.Models.Orgjed", "SifOrgjedNavigation")
                        .WithMany("Nastavnik")
                        .HasForeignKey("SifOrgjed")
                        .HasConstraintName("FK_nastavnik_orgjed")
                        .IsRequired();
                });

            modelBuilder.Entity("Fakultet.Models.Orgjed", b =>
                {
                    b.HasOne("Fakultet.Models.Orgjed", "SifNadorgjedNavigation")
                        .WithMany("InverseSifNadorgjedNavigation")
                        .HasForeignKey("SifNadorgjed")
                        .HasConstraintName("FK_orgjed_orgjed");
                });

            modelBuilder.Entity("Fakultet.Models.Pred", b =>
                {
                    b.HasOne("Fakultet.Models.Orgjed", "SifOrgjedNavigation")
                        .WithMany("Pred")
                        .HasForeignKey("SifOrgjed")
                        .HasConstraintName("FK_pred_orgjed");
                });

            modelBuilder.Entity("Fakultet.Models.PredNastavnik", b =>
                {
                    b.HasOne("Fakultet.Models.Nastavnik", "Nastavnik")
                        .WithMany()
                        .HasForeignKey("SifNastavnik")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fakultet.Models.Pred", "Predmet")
                        .WithMany()
                        .HasForeignKey("SifPred")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Fakultet.Models.Rezervacija", b =>
                {
                    b.HasOne("Fakultet.Models.Dvorana", "OznDvoranaNavigation")
                        .WithMany()
                        .HasForeignKey("OznDvorana")
                        .HasConstraintName("FK_rezervacija_dvorana")
                        .IsRequired();

                    b.HasOne("Fakultet.Models.Pred", "SifPredNavigation")
                        .WithMany()
                        .HasForeignKey("SifPred")
                        .HasConstraintName("FK_rezervacija_pred")
                        .IsRequired();
                });

            modelBuilder.Entity("Fakultet.Models.Stud", b =>
                {
                    b.HasOne("Fakultet.Models.Mjesto", "PbrRodNavigation")
                        .WithMany("StudPbrRodNavigation")
                        .HasForeignKey("PbrRod")
                        .HasConstraintName("FK_stud_mjesto");

                    b.HasOne("Fakultet.Models.Mjesto", "PbrStanNavigation")
                        .WithMany("StudPbrStanNavigation")
                        .HasForeignKey("PbrStan")
                        .HasConstraintName("FK_stud_mjesto1")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}