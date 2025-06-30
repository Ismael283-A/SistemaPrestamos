using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_DataAccess.Context;
using Capa_Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Capa_DataAccess.Repositories
{
    public class ArticuloRepository : IArticuloRepository
    {
        private readonly ContextDb _context;

        public ArticuloRepository(ContextDb context)
        {
            _context = context;
        }

        public async Task<List<Articulo>> GetAllAsync()
        {
            return await _context.Articulos.ToListAsync();
        }

        public async Task<Articulo?> GetByIdAsync(int id)
        {
            return await _context.Articulos.FindAsync(id);
        }

        public async Task AddAsync(Articulo articulo)
        {
            await _context.Articulos.AddAsync(articulo);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Articulo articulo)
        {
            _context.Articulos.Update(articulo);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var articulo = await _context.Articulos.FindAsync(id);
            if (articulo != null)
            {
                _context.Articulos.Remove(articulo);
                await _context.SaveChangesAsync();
            }
        }
    }
}
