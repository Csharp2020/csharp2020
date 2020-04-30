using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Fakultet.Models
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

        public virtual DbSet<PredNastavnik> PredNastavnik { get; set; }
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
                optionsBuilder.UseSqlServer("Server=LAPTOP-TF3CV7HA\\SQLEXPRESS;Initial Catalog=fakultet;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PredNastavnik>(entity =>
            {
                entity.HasKey(e => new { e.SifNastavnik, e.SifPred }); // kompozitni primarni kljuc je po defaultu unique

                entity.ToTable("pred_nastavnik");

                /*
                 entity.HasOne(d => d.SifNastavnikNavigation)
                     .WithMany()
                     .HasForeignKey(d => d.SifNastavnik)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_ispit_nastavnik");

     */
            });



            modelBuilder.Entity<Dvorana>(entity =>
            {
                entity.HasKey(e => e.OznDvorana);

                entity.ToTable("dvorana");

                entity.HasIndex(e => e.OznDvorana)
                    .HasName("dvoranaUnique")
                    .IsUnique();

                entity.Property(e => e.OznDvorana)
                    .HasColumnName("oznDvorana")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Kapacitet)
                    .HasColumnName("kapacitet")
                    .HasDefaultValueSql("((40))");
            });

            modelBuilder.Entity<Ispit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ispit");

                entity.Property(e => e.DatIspit)
                    .HasColumnName("datIspit")
                    .HasColumnType("datetime");

                entity.Property(e => e.MbrStud).HasColumnName("mbrStud");

                entity.Property(e => e.Ocjena)
                    .HasColumnName("ocjena")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SifNastavnik).HasColumnName("sifNastavnik");

                entity.Property(e => e.SifPred).HasColumnName("sifPred");

                entity.HasOne(d => d.MbrStudNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MbrStud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ispit_stud");

                entity.HasOne(d => d.SifNastavnikNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.SifNastavnik)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ispit_nastavnik");

                entity.HasOne(d => d.SifPredNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.SifPred)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ispit_pred");
            });

            modelBuilder.Entity<Mjesto>(entity =>
            {
                entity.HasKey(e => e.Pbr);

                entity.ToTable("mjesto");

                entity.HasIndex(e => e.NazMjesto)
                    .HasName("mjestoUnique");

                entity.HasIndex(e => e.Pbr)
                    .HasName("mjestoPbr")
                    .IsUnique();

                entity.Property(e => e.Pbr)
                    .HasColumnName("pbr")
                    .ValueGeneratedNever();

                entity.Property(e => e.NazMjesto)
                    .IsRequired()
                    .HasColumnName("nazMjesto")
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.SifZupanija).HasColumnName("sifZupanija");

                entity.HasOne(d => d.SifZupanijaNavigation)
                    .WithMany(p => p.Mjesto)
                    .HasForeignKey(d => d.SifZupanija)
                    .HasConstraintName("FK_mjesto_zupanija");
            });

            modelBuilder.Entity<Nastavnik>(entity =>
            {
                entity.HasKey(e => e.SifNastavnik);

                entity.ToTable("nastavnik");

                entity.HasIndex(e => e.SifNastavnik)
                    .HasName("nastavnikUnique")
                    .IsUnique();

                entity.Property(e => e.SifNastavnik)
                    .HasColumnName("sifNastavnik")
                    .ValueGeneratedNever();

                entity.Property(e => e.ImeNastavnik)
                    .IsRequired()
                    .HasColumnName("imeNastavnik")
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.Koef)
                    .HasColumnName("koef")
                    .HasColumnType("decimal(3, 2)");

                entity.Property(e => e.PbrStan).HasColumnName("pbrStan");

                entity.Property(e => e.PrezNastavnik)
                    .IsRequired()
                    .HasColumnName("prezNastavnik")
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.SifOrgjed).HasColumnName("sifOrgjed");

                entity.HasOne(d => d.PbrStanNavigation)
                    .WithMany(p => p.Nastavnik)
                    .HasForeignKey(d => d.PbrStan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_nastavnik_mjesto");

                entity.HasOne(d => d.SifOrgjedNavigation)
                    .WithMany(p => p.Nastavnik)
                    .HasForeignKey(d => d.SifOrgjed)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_nastavnik_orgjed");
            });

            modelBuilder.Entity<Orgjed>(entity =>
            {
                entity.HasKey(e => e.SifOrgjed);

                entity.ToTable("orgjed");

                entity.HasIndex(e => e.SifOrgjed)
                    .HasName("orgjedUnique")
                    .IsUnique();

                entity.Property(e => e.SifOrgjed)
                    .HasColumnName("sifOrgjed")
                    .ValueGeneratedNever();

                entity.Property(e => e.NazOrgjed)
                    .IsRequired()
                    .HasColumnName("nazOrgjed")
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.SifNadorgjed).HasColumnName("sifNadorgjed");

                entity.HasOne(d => d.SifNadorgjedNavigation)
                    .WithMany(p => p.InverseSifNadorgjedNavigation)
                    .HasForeignKey(d => d.SifNadorgjed)
                    .HasConstraintName("FK_orgjed_orgjed");
            });

            modelBuilder.Entity<Pred>(entity =>
            {
                entity.HasKey(e => e.SifPred);

                entity.ToTable("pred");

                entity.HasIndex(e => e.SifPred)
                    .HasName("predUnique")
                    .IsUnique();

                entity.Property(e => e.SifPred)
                    .HasColumnName("sifPred")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrojSatiTjedno).HasColumnName("brojSatiTjedno");

                entity.Property(e => e.KratPred)
                    .HasColumnName("kratPred")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NazPred)
                    .IsRequired()
                    .HasColumnName("nazPred")
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.SifOrgjed).HasColumnName("sifOrgjed");

                entity.Property(e => e.UpisanoStud).HasColumnName("upisanoStud");

                entity.HasOne(d => d.SifOrgjedNavigation)
                    .WithMany(p => p.Pred)
                    .HasForeignKey(d => d.SifOrgjed)
                    .HasConstraintName("FK_pred_orgjed");
            });

            modelBuilder.Entity<Rezervacija>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rezervacija");

                entity.Property(e => e.OznDvorana)
                    .IsRequired()
                    .HasColumnName("oznDvorana")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OznVrstaDan)
                    .IsRequired()
                    .HasColumnName("oznVrstaDan")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sat).HasColumnName("sat");

                entity.Property(e => e.SifPred).HasColumnName("sifPred");

                entity.HasOne(d => d.OznDvoranaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.OznDvorana)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rezervacija_dvorana");

                entity.HasOne(d => d.SifPredNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.SifPred)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rezervacija_pred");
            });

            modelBuilder.Entity<Stud>(entity =>
            {
                entity.HasKey(e => e.MbrStud);

                entity.ToTable("stud");

                entity.HasIndex(e => e.MbrStud)
                    .HasName("studUnique")
                    .IsUnique();

                entity.Property(e => e.MbrStud)
                    .HasColumnName("mbrStud")
                    .ValueGeneratedNever();

                entity.Property(e => e.DatRodStud)
                    .HasColumnName("datRodStud")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImeStud)
                    .IsRequired()
                    .HasColumnName("imeStud")
                    .HasMaxLength(25);

                entity.Property(e => e.JmbgStud)
                    .HasColumnName("jmbgStud")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PbrRod).HasColumnName("pbrRod");

                entity.Property(e => e.PbrStan).HasColumnName("pbrStan");

                entity.Property(e => e.PrezStud)
                    .IsRequired()
                    .HasColumnName("prezStud")
                    .HasMaxLength(25);

                entity.HasOne(d => d.PbrRodNavigation)
                    .WithMany(p => p.StudPbrRodNavigation)
                    .HasForeignKey(d => d.PbrRod)
                    .HasConstraintName("FK_stud_mjesto");

                entity.HasOne(d => d.PbrStanNavigation)
                    .WithMany(p => p.StudPbrStanNavigation)
                    .HasForeignKey(d => d.PbrStan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_stud_mjesto1");
            });

            modelBuilder.Entity<Zupanija>(entity =>
            {
                entity.HasKey(e => e.SifZupanija);

                entity.ToTable("zupanija");

                entity.HasIndex(e => e.SifZupanija)
                    .HasName("zupanijaUnique")
                    .IsUnique();

                entity.Property(e => e.SifZupanija)
                    .HasColumnName("sifZupanija")
                    .ValueGeneratedNever();

                entity.Property(e => e.NazZupanija)
                    .IsRequired()
                    .HasColumnName("nazZupanija")
                    .HasMaxLength(40)
                    .IsFixedLength();

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}