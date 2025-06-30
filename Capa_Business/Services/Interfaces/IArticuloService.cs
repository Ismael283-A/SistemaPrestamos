using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entities.Models;

namespace Capa_Business.Services.Interfaces
{
    public interface IArticuloService
    {
        Task<List<Articulo>> ObtenerTodosAsync();
        Task<Articulo?> ObtenerPorIdAsync(int id);
        Task CrearAsync(Articulo articulo);
        Task ActualizarAsync(Articulo articulo);
        Task EliminarAsync(int id);
    }
}
