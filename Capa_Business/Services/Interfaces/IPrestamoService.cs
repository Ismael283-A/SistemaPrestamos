using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entities.Models;

namespace Capa_Business.Services.Interfaces
{
    public interface IPrestamoService
    {
        Task<List<Prestamo>> ObtenerTodosAsync();
        Task<Prestamo?> ObtenerPorIdAsync(int id);
        Task CrearAsync(Prestamo prestamo);
        Task ActualizarAsync(Prestamo prestamo);
        Task EliminarAsync(int id);
    }
}
