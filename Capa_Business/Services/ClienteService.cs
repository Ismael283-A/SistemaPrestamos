using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Business.Services.Interfaces;
using Capa_DataAccess.Repositories.Interfaces;
using Capa_Entities.Models;

namespace Capa_Business.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repo;

        public ClienteService(IClienteRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Cliente>> ObtenerTodosAsync() => await _repo.ObtenerTodosAsync();
        public async Task<Cliente?> ObtenerPorCedulaAsync(string cedula) => await _repo.ObtenerPorCedulaAsync(cedula);
        public async Task CrearAsync(Cliente cliente) => await _repo.CrearAsync(cliente);
        public async Task ActualizarAsync(Cliente cliente) => await _repo.ActualizarAsync(cliente);
        public async Task EliminarAsync(string cedula) => await _repo.EliminarAsync(cedula);
    }
}
