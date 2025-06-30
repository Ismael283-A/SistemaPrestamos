using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using Capa_Business.Services.Interfaces;
using Capa_DataAccess.Context;
using Capa_Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Capa_Business.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly ContextDb _context;

        public UsuarioService(ContextDb context)
        {
            _context = context;
        }

        public async Task RegistrarAsync(Usuario usuario)
        {
            // Verifica que el empleado exista
            var empleado = await _context.Empleados.FindAsync(usuario.EmpleadoCedula);
            if (empleado == null)
            {
                throw new Exception($"Empleado con cédula {usuario.EmpleadoCedula} no existe.");
            }

            // Hashea la contraseña
            usuario.PasswordHash = BCrypt.Net.BCrypt.HashPassword(usuario.PasswordHash);

            // Rol por defecto
            usuario.Rol = "Operador";

            await _context.Usuarios.AddAsync(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task<Usuario?> LoginAsync(string username, string password)
        {
            var user = await _context.Usuarios.FirstOrDefaultAsync(u => u.UserName == username);

            // ⚠ Comparación directa de texto plano — solo para pruebas
            if (user != null && user.PasswordHash == password)
            {
                return user;
            }

            return null;
        }


        public async Task<List<Usuario>> ObtenerTodosAsync()
        {
            return await _context.Usuarios
                .Include(u => u.Empleado)
                .ToListAsync();
        }
      

    }
}
