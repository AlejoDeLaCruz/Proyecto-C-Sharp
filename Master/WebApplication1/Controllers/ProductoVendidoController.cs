using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet("GetProductosVendidos", Name = "GetProductosVendidos")]
        public IEnumerable<ProductoVendido> ProductosVendidos()
        {
            return ProductoVendidoBussiness.GetProductosVendidos();
        }

        [HttpGet("GetProductosVendidosPorId", Name = "GetProductosVendidosPorId")]
        public ActionResult<IEnumerable<ProductoVendido>> ProductosVendidosPorId(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Por favor introduzca un ID válido.");
            }

            var productosVendidos = ProductoVendidoBussiness.ObtenerProductoVendidoPorId(id);

            if (productosVendidos == null || productosVendidos.Count == 0)
            {
                return NotFound("No se encontraron productos vendidos con el ID proporcionado.");
            }

            return Ok(productosVendidos);
        }

        [HttpPost("CreateProductoVendido", Name = "CreateProductoVendido")]
        public ActionResult<string> Post([FromBody] ProductoVendido productoVendido)
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
        public ActionResult<string> Put([FromBody] ProductoVendido productoVendido)
        {
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

        [HttpDelete("DeleteProductosVendidos", Name = "DeleteProductosVendidos")]
        public ActionResult<string> Delete([FromBody] int id)
        {
            if (id <= 0)
            {
                return BadRequest("Por favor introduzca un ID válido.");
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
