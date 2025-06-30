using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entities.Models;

namespace Capa_DataAccess.Repositories
{
    public interface IArticuloRepository
    {
        Task<List<Articulo>> GetAllAsync();
        Task<Articulo?> GetByIdAsync(int id);
        Task AddAsync(Articulo articulo);
        Task UpdateAsync(Articulo articulo);
        Task DeleteAsync(int id);
    }
}
