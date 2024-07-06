using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities.Entidades;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet("GetProductosVendidos", Name = "GetProductosVendidos")]
        public IEnumerable<ProductoVendido> GetProductosVendidos()
        {
            return ProductoVendidoBussiness.GetProductosVendidos();
        }
        [HttpGet("GetProductosVendidosPorId", Name = "GetProductosVendidosPorId")]
        public ActionResult<ProductoVendido> GetProductosVendidosPorId(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Por favor, introduzca un ID válido.");
            }

            var productoVendido = ProductoVendidoBussiness.ObtenerProductoVendidoPorId(id);

            if (productoVendido == null)
            {
                return NotFound("No se encontró ningún producto vendido con el ID proporcionado.");
            }

            return Ok(productoVendido);
        }

        [HttpPost("CreateProductoVendido", Name = "CreateProductoVendido")]
        public ActionResult<string> CreateProductoVendido([FromBody] ProductoVendido productoVendido)
        {
            if (productoVendido.IdProducto <= 0)
            {
                return BadRequest("El campo IdProducto es obligatorio y debe ser mayor que cero.");
            }

            if (productoVendido.IdVenta <= 0)
            {
                return BadRequest("El campo IdVenta es obligatorio y debe ser mayor que cero.");
            }

            bool status = ProductoVendidoBussiness.CrearProductoVendido(productoVendido);
            if (!status)
            {
                return BadRequest("No se pudo crear el producto vendido.");
            }

            return Ok("Producto vendido creado exitosamente.");
        }

        [HttpPut("ModifyProductoVendido", Name = "ModifyProductoVendido")]
        public ActionResult<string> ModifyProductoVendido([FromBody] ProductoVendido productoVendido)
        {
            if (productoVendido.Id <= 0)
            {
                return BadRequest("El campo Id es obligatorio y debe ser mayor que cero.");
            }

            if (productoVendido.IdProducto <= 0)
            {
                return BadRequest("El campo IdProducto es obligatorio y debe ser mayor que cero.");
            }

            if (productoVendido.IdVenta <= 0)
            {
                return BadRequest("El campo IdVenta es obligatorio y debe ser mayor que cero.");
            }

            bool status = ProductoVendidoBussiness.ModificarProductoVendido(productoVendido);
            if (!status)
            {
                return BadRequest("No se pudo modificar el producto vendido.");
            }

            return Ok("Producto vendido modificado exitosamente.");
        }

        [HttpDelete("DeleteProductosVendidos/{id}", Name = "DeleteProductosVendidos")]
        public ActionResult<string> DeleteProductosVendidos(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Por favor, introduzca un ID válido.");
            }

            bool status = ProductoVendidoBussiness.EliminarProductoVendido(id);
            if (!status)
            {
                return BadRequest("No se pudo eliminar el producto vendido.");
            }

            return Ok("Producto vendido eliminado exitosamente.");
        }
    }
}