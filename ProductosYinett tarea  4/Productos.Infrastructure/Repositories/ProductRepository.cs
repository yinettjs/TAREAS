using Microsoft.EntityFrameworkCore;             
using Producto.Server.Models;
using Productos.Domain.Entities;                  
using Productos.Infrastructure.Interfaces;        

namespace Productos.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductosContext _context;

        public ProductRepository(ProductosContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Productoss>> GetAllAsync() =>
            await _context.Productos.ToListAsync();

        public async Task<Productoss?> GetByIdAsync(int id) =>
            await _context.Productos.FindAsync(id);

        public async Task AddAsync(Productoss product)
        {
            await _context.Productos.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Productoss product)
        {
            _context.Productos.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Productos.FindAsync(id);
            if (entity != null)
            {
                _context.Productos.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
