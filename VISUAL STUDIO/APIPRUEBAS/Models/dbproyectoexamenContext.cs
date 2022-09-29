using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace APIPRUEBAS.Models
{
    public partial class dbproyectoexamenContext : DbContext
    {
        public dbproyectoexamenContext()
        {
        }

        public dbproyectoexamenContext(DbContextOptions<dbproyectoexamenContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alumno> Alumnos { get; set; } = null!;
        public virtual DbSet<Calificacione> Calificaciones { get; set; } = null!;
        public virtual DbSet<Materia> Materias { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.HasKey(e => e.IdAlumno)
                    .HasName("PK__alumno__43FBBAC79856A504");

                entity.ToTable("alumno");

                entity.Property(e => e.IdAlumno).HasColumnName("idAlumno");

                entity.Property(e => e.Apellido_Ma)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Apellido_Ma");

                entity.Property(e => e.Apellido_Pa)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Apellido_Pa");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Calificacione>(entity =>
            {
                entity.HasKey(e => e.IdCali)
                    .HasName("PK__califica__8BC7AB65554BC884");

                entity.ToTable("calificaciones");

                entity.Property(e => e.IdCali).HasColumnName("idCali");

                entity.Property(e => e.Calificaciones).HasColumnName("calificaciones");

                entity.Property(e => e.IdAlumno).HasColumnName("idAlumno");

                entity.Property(e => e.IdMateria).HasColumnName("idMateria");

               
            });

            modelBuilder.Entity<Materia>(entity =>
            {
                entity.HasKey(e => e.IdMateria)
                    .HasName("PK__materias__4B740AB3D3344176");

                entity.ToTable("materias");

                entity.Property(e => e.IdMateria).HasColumnName("idMateria");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
