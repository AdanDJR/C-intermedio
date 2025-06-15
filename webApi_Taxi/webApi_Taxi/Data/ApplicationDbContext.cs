using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using webApi_Taxi.Models;

namespace webApi_Taxi.Data;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DetalleViaje> DetalleViajes { get; set; }

    public virtual DbSet<GrupoUsuario> GrupoUsuarios { get; set; }

    public virtual DbSet<GrupoUsuariosDetalle> GrupoUsuariosDetalles { get; set; }

    public virtual DbSet<Taxi> Taxis { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Viaje> Viajes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=VICTORFDJ;Database=Taxi_BD;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DetalleViaje>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DetalleV__3214EC0709E08A33");

            entity.ToTable("DetalleViaje");

            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.Viaje).WithMany(p => p.DetalleViajes)
                .HasForeignKey(d => d.ViajeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DetalleVi__Viaje__45F365D3");
        });

        modelBuilder.Entity<GrupoUsuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GrupoUsu__3214EC070D12E4CA");
        });

        modelBuilder.Entity<GrupoUsuariosDetalle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GrupoUsu__3214EC0756334060");

            entity.ToTable("GrupoUsuariosDetalle");

            entity.HasOne(d => d.GrupoUsuarios).WithMany(p => p.GrupoUsuariosDetalles)
                .HasForeignKey(d => d.GrupoUsuariosId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GrupoUsua__Grupo__5441852A");

            entity.HasOne(d => d.Usuario).WithMany(p => p.GrupoUsuariosDetalles)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GrupoUsua__Usuar__5535A963");
        });

        modelBuilder.Entity<Taxi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Taxi__3214EC07CB5774A1");

            entity.ToTable("Taxi");

            entity.Property(e => e.Placa)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3214EC07A77FA9B1");

            entity.ToTable("Usuario");

            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.GrupoUsuarios).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.GrupoUsuariosId)
                .HasConstraintName("FK__Usuario__GrupoUs__5165187F");
        });

        modelBuilder.Entity<Viaje>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Viaje__3214EC0723C9F37E");

            entity.ToTable("Viaje");

            entity.Property(e => e.Desde)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.Hasta)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
