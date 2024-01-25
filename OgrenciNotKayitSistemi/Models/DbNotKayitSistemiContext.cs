using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OgrenciNotKayitSistemi.Models
{
    public partial class DbNotKayitSistemiContext : DbContext
    {
        public DbNotKayitSistemiContext()
        {
        }

        public DbNotKayitSistemiContext(DbContextOptions<DbNotKayitSistemiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblDer> TblDers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=UMUR;Initial Catalog=DbNotKayitSistemi;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblDer>(entity =>
            {
                entity.HasKey(e => e.OgrenciId);

                entity.ToTable("tblDers");

                entity.Property(e => e.OgrenciId).HasColumnName("OgrenciID");

                entity.Property(e => e.OgrenciAd)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OgrenciNo)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OgrenciSoyad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ortalama).HasColumnType("decimal(18, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
