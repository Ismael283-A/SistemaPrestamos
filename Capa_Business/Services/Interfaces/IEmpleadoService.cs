using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entities.Models;

namespace Capa_Business.Services.Interfaces
{
    public interface IEmpleadoService
    {
        Task<IEnumerable<Object>> ObtenerTodosAsync();
        Task<Empleado?> ObtenerPorCedulaAsync(string cedula);
        Task CrearAsync(Empleado empleado);
        Task ActualizarAsync(Empleado empleado);
        Task EliminarAsync(string cedula);
    }
}
