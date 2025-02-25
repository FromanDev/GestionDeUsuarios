using GestionDeUsuarios.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionDeUsuarios.Data
{
    public class GestionUsuarioDBContext : DbContext
    {
        public GestionUsuarioDBContext(DbContextOptions<GestionUsuarioDBContext> options) : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.Property(e => e.IdUsuario)
                    .UseIdentityColumn()
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NombreUsuario)
                .HasMaxLength(100);

                entity.Property(e => e.FechaCreacionUsuario)
                .HasColumnType("datetime");
            });
        }
    }
}