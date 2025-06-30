using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_DataAccess.Context;
using Capa_DataAccess.Repositories.Interfaces;
using Capa_Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Capa_DataAccess.Repositories
{
    public class EmpleadoRepository : IEmpleadoRepository
    {
        private readonly ContextDb _context;

        public EmpleadoRepository(ContextDb context)
        {
            _context = context;
        }

        public async Task<Empleado?> ObtenerPorIdAsync(string cedula)
        {
            return await _context.Empleados.FindAsync(cedula);
        }

        public async Task<IEnumerable<Empleado>> ObtenerTodosAsync()
        {
            return await _context.Empleados.Include(e => e.Usuarios).ToListAsync();
        }

        public async Task CrearAsync(Empleado empleado)
        {
            _context.Empleados.Add(empleado);
            await _context.SaveChangesAsync();
        }

        public async Task ActualizarAsync(Empleado empleado)
        {
            _context.Empleados.Update(empleado);
            await _context.SaveChangesAsync();
        }

        public async Task EliminarAsync(string cedula)
        {
            var empleado = await _context.Empleados.FindAsync(cedula);
            if (empleado != null)
            {
                _context.Empleados.Remove(empleado);
                await _context.SaveChangesAsync();
            }
        }
    }
}
