using Producto.Server.Models;
using Productos.Domain.Entities;

namespace Productos.Infrastructure.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Productoss>> GetAllAsync();
        Task<Productoss?> GetByIdAsync(int id);
        Task AddAsync(Productoss product);
        Task UpdateAsync(Productoss product);
        Task DeleteAsync(int id);
    }
}
