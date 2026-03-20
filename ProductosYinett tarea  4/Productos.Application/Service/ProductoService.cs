using Productos.Application.Contract;
using Productos.Application.Dtos;
using Productos.Domain.Entities;
using Productos.Infrastructure.Interfaces;

namespace Productos.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            var products = await _repository.GetAllAsync();
            return products.Select(p => new ProductDto
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Descripcion = p.Descripcion,
                Precio = p.Precio
            });
        }

        public async Task<ProductDto?> GetByIdAsync(int id)
        {
            var product = await _repository.GetByIdAsync(id);
            if (product == null) return null;

            return new ProductDto
            {
                Id = product.Id,
                Nombre = product.Nombre,
                Descripcion = product.Descripcion,
                Precio = product.Precio
            };
        }

        public async Task<ProductDto> CreateAsync(ProductDto dto)
        {
            var entity = new Productoss
            {
                Nombre = dto.Nombre,
                Descripcion = dto.Descripcion,
                Precio = dto.Precio
            };

            await _repository.AddAsync(entity);
            dto.Id = entity.Id;
            return dto;
        }

        public async Task<ProductDto> UpdateAsync(ProductDto dto)
        {
            var entity = new Productoss
            {
                Id = dto.Id,
                Nombre = dto.Nombre,
                Descripcion = dto.Descripcion,
                Precio = dto.Precio
            };

            await _repository.UpdateAsync(entity);
            return dto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
            return true;
        }
    }
}

