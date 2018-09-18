using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Requerimientos_Stack_Csharp.Models
{
    public partial class dbDominicanoSRLContext : DbContext
    {
        public dbDominicanoSRLContext()
        {
        }

        public dbDominicanoSRLContext(DbContextOptions<dbDominicanoSRLContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=192.168.100.237;Database=dbDominicanoSRL;User Id=mem; Password = 123456; ");
                //"Data Source=ASUS;Initial Catalog=dbDominicanoSRL;Integrated Security=False;User ID=sa;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
                //192.168.100.237
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Idusuario);

                entity.ToTable("usuario");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.Acceso)
                    .HasColumnName("acceso")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Habilitado)
                    .HasColumnName("habilitado")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Movil)
                    .HasColumnName("movil")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Nombrecompleto)
                    .IsRequired()
                    .HasColumnName("nombrecompleto")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumDocumento)
                    .IsRequired()
                    .HasColumnName("num_documento")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasColumnName("sexo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("userName")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
        }
    }
}
