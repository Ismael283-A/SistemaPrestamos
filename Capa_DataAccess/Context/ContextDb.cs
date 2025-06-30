using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Capa_DataAccess.Context
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions<ContextDb> options)
            : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Observacion> Observaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Claves primarias explícitas para cadenas
            modelBuilder.Entity<Empleado>().HasKey(e => e.Cedula);
            modelBuilder.Entity<Cliente>().HasKey(c => c.Cedula);

            // Relación 1:N Prestamo → Observaciones
            modelBuilder.Entity<Prestamo>()
                .HasMany(p => p.Observaciones)
                .WithOne(o => o.Prestamo)
                .HasForeignKey(o => o.PrestamoId)
                .OnDelete(DeleteBehavior.Cascade);

            // Articulo → Prestamos
            modelBuilder.Entity<Prestamo>()
                .HasOne(p => p.Articulo)
                .WithMany(a => a.Prestamos)
                .HasForeignKey(p => p.ArticuloId);

            // Empleado → Prestamos
            modelBuilder.Entity<Prestamo>()
                .HasOne(p => p.Empleado)
                .WithMany(e => e.Prestamos)
                .HasForeignKey(p => p.EmpleadoCedula);

            // Cliente → Prestamos
            modelBuilder.Entity<Prestamo>()
                .HasOne(p => p.Cliente)
                .WithMany(c => c.Prestamos)
                .HasForeignKey(p => p.ClienteCedula);
            //Relacion entre empleado-> Usuario
            modelBuilder.Entity<Usuario>()
    .HasOne(u => u.Empleado)
    .WithMany(e => e.Usuarios)
    .HasForeignKey(u => u.EmpleadoCedula);

        }
    }
}
