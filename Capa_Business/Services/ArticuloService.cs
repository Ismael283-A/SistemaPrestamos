using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Business.Services.Interfaces;
using Capa_DataAccess.Repositories;
using Capa_Entities.Models;

namespace Capa_Business.Services
{
    public class ArticuloService : IArticuloService
    {
        private readonly IArticuloRepository _repo;

        public ArticuloService(IArticuloRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Articulo>> ObtenerTodosAsync() => await _repo.GetAllAsync();

        public async Task<Articulo?> ObtenerPorIdAsync(int id) => await _repo.GetByIdAsync(id);

        public async Task CrearAsync(Articulo articulo) => await _repo.AddAsync(articulo);

        public async Task ActualizarAsync(Articulo articulo) => await _repo.UpdateAsync(articulo);

        public async Task EliminarAsync(int id) => await _repo.DeleteAsync(id);
    }
}
