using Productos.Application.Dtos;

namespace Productos.Application.Contract
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllAsync();
        Task<ProductDto?> GetByIdAsync(int id);
        Task<ProductDto> CreateAsync(ProductDto dto);
        Task<ProductDto> UpdateAsync(ProductDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
