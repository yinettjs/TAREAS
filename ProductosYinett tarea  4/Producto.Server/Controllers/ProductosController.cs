using Microsoft.AspNetCore.Mvc;
using Productos.Application.Contract;   
using Productos.Application.Dtos;      

namespace Producto.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductosController(IProductService service)
        {
            _service = service;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearProducto([FromBody] ProductDto producto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _service.CreateAsync(producto);
            return Ok(result);
        }

        [HttpGet("listaProducto")]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
        {
            var productos = await _service.GetAllAsync();
            return Ok(productos);
        }

        [HttpGet("verProducto/{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var producto = await _service.GetByIdAsync(id);
            if (producto == null)
                return NotFound();

            return Ok(producto);
        }

        [HttpPut("editarProducto/{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] ProductDto producto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            producto.Id = id;
            var result = await _service.UpdateAsync(producto);
            return Ok(result);
        }

        [HttpDelete("eliminarProducto/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var deleted = await _service.DeleteAsync(id);
            if (!deleted)
                return NotFound();

            return Ok(new { message = "Producto eliminado correctamente" });
        }
    }
}
