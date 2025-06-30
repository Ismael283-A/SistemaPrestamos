using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entities.Models;

namespace Capa_DataAccess.Repositories.Interfaces
{
    public interface IEmpleadoRepository
    {
        Task<Empleado?> ObtenerPorIdAsync(string cedula);
        Task<IEnumerable<Empleado>> ObtenerTodosAsync();
        Task CrearAsync(Empleado empleado);
        Task ActualizarAsync(Empleado empleado);
        Task EliminarAsync(string cedula);
    }
}
