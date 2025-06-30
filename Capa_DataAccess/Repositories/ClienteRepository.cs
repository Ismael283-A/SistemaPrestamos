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
    public class ClienteRepository : IClienteRepository
    {
        private readonly ContextDb _context;
        public ClienteRepository(ContextDb context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cliente>> ObtenerTodosAsync() => await _context.Clientes.ToListAsync();

        public async Task<Cliente?> ObtenerPorCedulaAsync(string cedula) => await _context.Clientes.FindAsync(cedula);

        public async Task CrearAsync(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task ActualizarAsync(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task EliminarAsync(string cedula)
        {
            var cliente = await _context.Clientes.FindAsync(cedula);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }
    }
}
