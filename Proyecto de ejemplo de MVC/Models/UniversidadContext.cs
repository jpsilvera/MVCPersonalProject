using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Proyecto_de_ejemplo_de_MVC.Models
{
    public partial class UniversidadContext : DbContext
    {
        public UniversidadContext()
        {
        }

        public UniversidadContext(DbContextOptions<UniversidadContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Academic> Academic { get; set; }
        public virtual DbSet<Carrera> Carrera { get; set; }
        public virtual DbSet<Cmateria> Cmateria { get; set; }
        public virtual DbSet<Estudian> Estudian { get; set; }
        public virtual DbSet<Grupo> Grupo { get; set; }
        public virtual DbSet<Materia> Materia { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Universidad;Persist Security Info=False;Integrated Security=true;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Academic>(entity =>
            {
                entity.HasKey(e => e.Anoemplead)
                    .HasName("PK__academic__4C0022EB8E538E59");

                entity.ToTable("academic");

                entity.Property(e => e.Anoemplead)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Adomicilio)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Afecalta).HasColumnType("date");

                entity.Property(e => e.Anocarrera)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Anombre)
                    .IsRequired()
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.Asueldo).HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<Carrera>(entity =>
            {
                entity.HasKey(e => e.Cnocarrera)
                    .HasName("PK__carrera__8176D266CDAAA104");

                entity.ToTable("carrera");

                entity.Property(e => e.Cnocarrera)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Ccoord)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Cedificio)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cnombre)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cmateria>(entity =>
            {
                entity.HasKey(e => e.Mnomateria)
                    .HasName("PK__cmateria__7E95449A4F673398");

                entity.ToTable("cmateria");

                entity.Property(e => e.Mnomateria)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Mcostolab).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Mnocarrera)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Mnombre)
                    .IsRequired()
                    .HasMaxLength(42)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Estudian>(entity =>
            {
                entity.HasKey(e => e.Enocuenta)
                    .HasName("PK__estudian__D057A3E81B1BEB5B");

                entity.ToTable("estudian");

                entity.Property(e => e.Enocuenta)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Edomicilio)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Efecnacim).HasColumnType("date");

                entity.Property(e => e.Enocarrera)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Enombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Etelefono)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Grupo>(entity =>
            {
                entity.HasKey(e => e.Gnogrupo)
                    .HasName("PK__grupo__7A62349C8386B61F");

                entity.ToTable("grupo");

                entity.Property(e => e.Gnogrupo)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Gdias)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Ghora)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Gnomaestro)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Gnomateria)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Gsalon)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Materia>(entity =>
            {
                entity.HasKey(e => e.Mnomateria)
                    .HasName("PK__materia__7E95449AE6606905");

                entity.ToTable("materia");

                entity.Property(e => e.Mnomateria)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Mcostolab).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Mnocarrera)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Mnombre)
                    .IsRequired()
                    .HasMaxLength(42)
                    .IsUnicode(false);
            });
        }
    }
}
