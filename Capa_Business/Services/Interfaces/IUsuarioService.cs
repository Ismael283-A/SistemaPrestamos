using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entities.Models;

namespace Capa_Business.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task RegistrarAsync(Usuario usuario);
        Task<Usuario?> LoginAsync(string username, string password);
        Task<List<Usuario>> ObtenerTodosAsync();
        
    }
}
