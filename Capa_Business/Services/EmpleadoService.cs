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
    public class EmpleadoService : IEmpleadoService
    {
        private readonly IEmpleadoRepository _empleadoRepository;

        public EmpleadoService(IEmpleadoRepository empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }

        //public async Task<IEnumerable<Empleado>> ObtenerTodosAsync()
        //{
        //    return await _empleadoRepository.ObtenerTodosAsync();
        //}
        //public async Task<IEnumerable<object>> ObtenerTodosAsync()
        //{
        //    var empleados = await _empleadoRepository.ObtenerTodosAsync();

        //    return empleados.Select(e => new
        //    {
        //        e.Cedula,
        //        e.Nombre,
        //        e.Apellido,
        //        e.Telefono,
        //        e.Correo,
        //        Usuario = e.Usuarios.FirstOrDefault() != null ? new
        //        {
        //            e.Usuarios.FirstOrDefault().UserName,
        //            e.Usuarios.FirstOrDefault().Rol
        //        } : null
        //    });
        //}
        public async Task<IEnumerable<object>> ObtenerTodosAsync()
        {
            var empleados = await _empleadoRepository.ObtenerTodosAsync();

            return empleados.Select(e => new
            {
                e.Cedula,
                e.Nombre,
                e.Apellido,
                e.Telefono,
                e.Correo,
                usuario = e.Usuarios.FirstOrDefault() != null ? new
                {
                    userName = e.Usuarios.FirstOrDefault().UserName,
                    rol = e.Usuarios.FirstOrDefault().Rol
                } : null
            });
        }


        public async Task<Empleado?> ObtenerPorCedulaAsync(string cedula)
        {
            return await _empleadoRepository.ObtenerPorIdAsync(cedula);
        }

        public async Task CrearAsync(Empleado empleado)
        {
            await _empleadoRepository.CrearAsync(empleado);
        }

        public async Task ActualizarAsync(Empleado empleado)
        {
            await _empleadoRepository.ActualizarAsync(empleado);
        }

        public async Task EliminarAsync(string cedula)
        {
            await _empleadoRepository.EliminarAsync(cedula);
        }

    }
}
