using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Firma.Models
{
    public partial class FakultetContext : DbContext
    {
        public FakultetContext()
        {
        }

        public FakultetContext(DbContextOptions<FakultetContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dvorana> Dvorana { get; set; }
        public virtual DbSet<Ispit> Ispit { get; set; }
        public virtual DbSet<Mjesto> Mjesto { get; set; }
        public virtual DbSet<Nastavnik> Nastavnik { get; set; }
        public virtual DbSet<Orgjed> Orgjed { get; set; }
        public virtual DbSet<Pred> Pred { get; set; }
        public virtual DbSet<Rezervacija> Rezervacija { get; set; }
        public virtual DbSet<Stud> Stud { get; set; }
        public virtual DbSet<Zupanija> Zupanija { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=POWERRYZEN\\SQLEXPRESS;Initial Catalog=Fakultet;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dvorana>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dvorana");

                entity.Property(e => e.Kapacitet).HasColumnName("kapacitet");

                entity.Property(e => e.OznDvorana)
                    .IsRequired()
                    .HasColumnName("oznDvorana")
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<Ispit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ispit");

                entity.Property(e => e.DatIspit)
                    .HasColumnName("datIspit")
                    .HasColumnType("datetime");

                entity.Property(e => e.MbrStud).HasColumnName("mbrStud");

                entity.Property(e => e.Ocjena).HasColumnName("ocjena");

                entity.Property(e => e.SifNastavnik).HasColumnName("sifNastavnik");

                entity.Property(e => e.SifPred).HasColumnName("sifPred");
            });

            modelBuilder.Entity<Mjesto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mjesto");

                entity.Property(e => e.NazMjesto)
                    .IsRequired()
                    .HasColumnName("nazMjesto")
                    .HasMaxLength(40);

                entity.Property(e => e.Pbr).HasColumnName("pbr");

                entity.Property(e => e.SifZupanija).HasColumnName("sifZupanija");
            });

            modelBuilder.Entity<Nastavnik>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("nastavnik");

                entity.Property(e => e.ImeNastavnik)
                    .IsRequired()
                    .HasColumnName("imeNastavnik")
                    .HasMaxLength(25);

                entity.Property(e => e.Koef)
                    .HasColumnName("koef")
                    .HasColumnType("decimal(3, 2)");

                entity.Property(e => e.PbrStan).HasColumnName("pbrStan");

                entity.Property(e => e.PrezNastavnik)
                    .IsRequired()
                    .HasColumnName("prezNastavnik")
                    .HasMaxLength(25);

                entity.Property(e => e.SifNastavnik).HasColumnName("sifNastavnik");

                entity.Property(e => e.SifOrgjed).HasColumnName("sifOrgjed");
            });

            modelBuilder.Entity<Orgjed>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("orgjed");

                entity.Property(e => e.NazOrgjed)
                    .IsRequired()
                    .HasColumnName("nazOrgjed")
                    .HasMaxLength(60);

                entity.Property(e => e.SifNadorgjed).HasColumnName("sifNadorgjed");

                entity.Property(e => e.SifOrgjed).HasColumnName("sifOrgjed");
            });

            modelBuilder.Entity<Pred>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pred");

                entity.Property(e => e.BrojSatiTjedno).HasColumnName("brojSatiTjedno");

                entity.Property(e => e.KratPred)
                    .HasColumnName("kratPred")
                    .HasMaxLength(8);

                entity.Property(e => e.NazPred)
                    .IsRequired()
                    .HasColumnName("nazPred")
                    .HasMaxLength(60);

                entity.Property(e => e.SifOrgjed).HasColumnName("sifOrgjed");

                entity.Property(e => e.SifPred).HasColumnName("sifPred");

                entity.Property(e => e.UpisanoStud).HasColumnName("upisanoStud");
            });

            modelBuilder.Entity<Rezervacija>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rezervacija");

                entity.Property(e => e.OznDvorana)
                    .IsRequired()
                    .HasColumnName("oznDvorana")
                    .HasMaxLength(5);

                entity.Property(e => e.OznVrstaDan)
                    .IsRequired()
                    .HasColumnName("oznVrstaDan")
                    .HasMaxLength(2);

                entity.Property(e => e.Sat).HasColumnName("sat");

                entity.Property(e => e.SifPred).HasColumnName("sifPred");
            });

            modelBuilder.Entity<Stud>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("stud");

                entity.Property(e => e.DatRodStud)
                    .HasColumnName("datRodStud")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImeStud)
                    .IsRequired()
                    .HasColumnName("imeStud")
                    .HasMaxLength(25);

                entity.Property(e => e.JmbgStud)
                    .HasColumnName("jmbgStud")
                    .HasMaxLength(13);

                entity.Property(e => e.MbrStud).HasColumnName("mbrStud");

                entity.Property(e => e.PbrRod).HasColumnName("pbrRod");

                entity.Property(e => e.PbrStan).HasColumnName("pbrStan");

                entity.Property(e => e.PrezStud)
                    .IsRequired()
                    .HasColumnName("prezStud")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Zupanija>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zupanija");

                entity.Property(e => e.NazZupanija)
                    .IsRequired()
                    .HasColumnName("nazZupanija")
                    .HasMaxLength(40);

                entity.Property(e => e.SifZupanija).HasColumnName("sifZupanija");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
