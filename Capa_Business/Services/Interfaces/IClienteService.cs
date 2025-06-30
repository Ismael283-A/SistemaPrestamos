using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entities.Models;

namespace Capa_Business.Services.Interfaces
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> ObtenerTodosAsync();
        Task<Cliente?> ObtenerPorCedulaAsync(string cedula);
        Task CrearAsync(Cliente cliente);
        Task ActualizarAsync(Cliente cliente);
        Task EliminarAsync(string cedula);
    }
}
