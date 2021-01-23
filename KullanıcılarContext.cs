using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Data.Models
{
    public partial class KullanıcılarContext : DbContext
    {
        public KullanıcılarContext()
        {
        }

        public KullanıcılarContext(DbContextOptions<KullanıcılarContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Musteriler> Musterilers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=Kullanıcılar;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Musteriler>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Musteriler");

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ad");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Sifre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sifre");

                entity.Property(e => e.Soyad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("soyad");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
