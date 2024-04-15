using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using RentACar.Entities;

namespace RentACar.DAL;

public partial class RentacarContext : DbContext
{
    public RentacarContext()
    {
    }

    public RentacarContext(DbContextOptions<RentacarContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Araba> Arabas { get; set; }

    public virtual DbSet<Kiralama> Kiralamas { get; set; }

    public virtual DbSet<Musteri> Musteris { get; set; }

    public virtual DbSet<Yonetici> Yoneticis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)=> optionsBuilder.UseSqlServer("Server=202-HOCAPC;Database=RENTACAR;Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Araba>(entity =>
        {
            entity.HasKey(e => e.Plaka);

            entity.ToTable("Araba");

            entity.Property(e => e.Plaka)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.Fiyat).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.KasaTipi)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Marka)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Renk)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Vites)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Yakıt)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Kiralama>(entity =>
        {
            entity.ToTable("Kiralama");

            entity.Property(e => e.Odeme).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Musteri>(entity =>
        {
            entity.ToTable("Musteri");

            entity.Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Bakiye).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EhliyetNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tc).HasColumnName("TC");
            entity.Property(e => e.Telefon)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Yonetici>(entity =>
        {
            entity.ToTable("Yonetici");

            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
