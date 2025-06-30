using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Business.Services.Interfaces;
using Capa_DataAccess.Context;
using Capa_DataAccess.Repositories.Interfaces;
using Capa_Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Capa_Business.Services
{
    public class PrestamoService : IPrestamoService
    {
        private readonly IPrestamoRepository _repository;
        public PrestamoService(IPrestamoRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Prestamo>> ObtenerTodosAsync()
        {
            return await _repository.ObtenerTodosAsync();
        }

        public async Task<Prestamo?> ObtenerPorIdAsync(int id)
        {
            return await _repository.ObtenerPorIdAsync(id);
        }

        public async Task CrearAsync(Prestamo prestamo)
        {
            await _repository.CrearAsync(prestamo);
        }

        public async Task ActualizarAsync(Prestamo prestamo)
        {
            await _repository.ActualizarAsync(prestamo);
        }

        public async Task EliminarAsync(int id)
        {
            await _repository.EliminarAsync(id);
        }
    }

}
