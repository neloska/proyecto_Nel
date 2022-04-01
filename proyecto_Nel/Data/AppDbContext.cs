using Microsoft.EntityFrameworkCore;
using proyecto_Nel.Models;

namespace proyecto_Nel.Data
{
    public class AppDbContext : DbContext
    {
        //traductor de los modelos c# al codigo de sql

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)//constructor
        {

        }

        //relaciones uno a muchos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<propietarios_propiedad>().HasKey(am => new
            {
                am.IdPropietario,
                am.IdPropiedad
            });

            modelBuilder.Entity<propietarios_propiedad>().HasOne(m => m.propiedades).WithMany(am => am.propietarios_propiedad).HasForeignKey(m =>
            m.IdPropiedad);
            modelBuilder.Entity<propietarios_propiedad>().HasOne(m => m.propietario).WithMany(am => am.propietarios_propiedad).HasForeignKey(m =>
            m.IdPropietario);

            base.OnModelCreating(modelBuilder); 

        }

        public DbSet<propietario> propietario { get; set; }
        public DbSet<propiedades> propiedades { get; set; }
        public DbSet<propietarios_propiedad> propietarios_propiedad { get; set; }
        public DbSet<ciudades> ciudades { get; set; }
        public DbSet<empleados> empleados { get; set; }
    }

}
