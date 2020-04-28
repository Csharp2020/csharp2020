using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Faxi.Models
{
    public partial class videotekaContext : DbContext
    {
        public videotekaContext()
        {
        }

        public videotekaContext(DbContextOptions<videotekaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Evidencije> Evidencije { get; set; }
        public virtual DbSet<Mediji> Mediji { get; set; }
        public virtual DbSet<Prijatelji> Prijatelji { get; set; }
        public virtual DbSet<VNevraceni> VNevraceni { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=videoteka;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Evidencije>(entity =>
            {
                entity.HasKey(e => new { e.PrijateljiId, e.MedijiId });

                entity.Property(e => e.PrijateljiId).HasColumnName("prijatelji_id");

                entity.Property(e => e.MedijiId).HasColumnName("mediji_id");

                entity.Property(e => e.DatumPosudbe)
                    .HasColumnName("datum_posudbe")
                    .HasColumnType("date");

                entity.Property(e => e.DatumVracanja)
                    .HasColumnName("datum_vracanja")
                    .HasColumnType("date");

                entity.HasOne(d => d.Mediji)
                    .WithMany(p => p.Evidencije)
                    .HasForeignKey(d => d.MedijiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Evidencije_Mediji");

                entity.HasOne(d => d.Prijatelji)
                    .WithMany(p => p.Evidencije)
                    .HasForeignKey(d => d.PrijateljiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Evidencije_Prijatelji");
            });

            modelBuilder.Entity<Mediji>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasColumnName("naziv")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Vrsta).HasColumnName("vrsta");
            });

            modelBuilder.Entity<Prijatelji>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasColumnName("ime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasColumnName("prezime")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VNevraceni>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_nevraceni");

                entity.Property(e => e.Dani).HasColumnName("dani");

                entity.Property(e => e.DatumPosudbe)
                    .HasColumnName("datum_posudbe")
                    .HasColumnType("date");

                entity.Property(e => e.DatumVracanja)
                    .HasColumnName("datum_vracanja")
                    .HasColumnType("date");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasColumnName("ime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedijiId).HasColumnName("mediji_id");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasColumnName("naziv")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasColumnName("prezime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrijateljiId).HasColumnName("prijatelji_id");

                entity.Property(e => e.Vrsta).HasColumnName("vrsta");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
