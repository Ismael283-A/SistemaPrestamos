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
    public class PrestamoRepository : IPrestamoRepository
    {
        private readonly ContextDb _context;
        public PrestamoRepository(ContextDb context)
        {
            _context = context;
        }

        public async Task<List<Prestamo>> ObtenerTodosAsync()
        {
            return await _context.Prestamos
                .Include(p => p.Articulo)
                .Include(p => p.Empleado)
                .Include(p => p.Cliente)
                .Include(p => p.Observaciones)
                .ToListAsync();
        }

        public async Task<Prestamo?> ObtenerPorIdAsync(int id)
        {
            return await _context.Prestamos
                .Include(p => p.Articulo)
                .Include(p => p.Empleado)
                .Include(p => p.Cliente)
                .Include(p => p.Observaciones)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task CrearAsync(Prestamo prestamo)
        {
            _context.Prestamos.Add(prestamo);
            await _context.SaveChangesAsync();
        }

        public async Task ActualizarAsync(Prestamo prestamo)
        {
            _context.Prestamos.Update(prestamo);
            await _context.SaveChangesAsync();
        }

        public async Task EliminarAsync(int id)
        {
            var prestamo = await _context.Prestamos.FindAsync(id);
            if (prestamo != null)
            {
                _context.Prestamos.Remove(prestamo);
                await _context.SaveChangesAsync();
            }
        }
    }


}

