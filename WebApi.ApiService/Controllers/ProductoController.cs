using Microsoft.AspNetCore.Mvc;
using WebApi.ApiService.Entidades;
using WebApi.ApiService.Negocio;

namespace WebApi.ApiService.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _productoService;

        public ProductoController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        
        [HttpGet]
        public IActionResult Get() => Ok(_productoService.ObtenerTodos());

        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var producto = _productoService.ObtenerPorId(id);
            return producto == null ? NotFound() : Ok(producto);
        }

        
        [HttpPost]
        public IActionResult Post(Producto producto)
        {
            _productoService.Agregar(producto);
            return CreatedAtAction(nameof(Get), new { id = producto.Id }, producto);
        }

       
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return _productoService.Eliminar(id) ? NoContent() : NotFound();
        }
    }
}

