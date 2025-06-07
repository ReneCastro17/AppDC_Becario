using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AppDC_Hernández.Models;

public partial class DbecarioHernandezContext : DbContext
{
    public DbecarioHernandezContext()
    {
    }

    public DbecarioHernandezContext(DbContextOptions<DbecarioHernandezContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TReclamo> TReclamos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=LAPTOP-UEJ65DK5;Database=DBecario_Hernandez;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TReclamo>(entity =>
        {
            entity.HasKey(e => e.IdReclamo).HasName("PK__t_reclam__5EB0D86419162D9C");

            entity.ToTable("t_reclamos");

            entity.Property(e => e.IdReclamo).HasColumnName("idReclamo");
            entity.Property(e => e.ApellidosConsumidor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellidosConsumidor");
            entity.Property(e => e.DettalleReclamo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("dettalleReclamo");
            entity.Property(e => e.DireccionProveedor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccionProveedor");
            entity.Property(e => e.Dui)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DUI");
            entity.Property(e => e.FechaIngrese)
                .HasColumnType("datetime")
                .HasColumnName("fechaIngrese");
            entity.Property(e => e.MontoReclamado)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("montoReclamado");
            entity.Property(e => e.NombreProveedor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreProveedor");
            entity.Property(e => e.NombresConsumidor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombresConsumidor");
            entity.Property(e => e.Telefono)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
