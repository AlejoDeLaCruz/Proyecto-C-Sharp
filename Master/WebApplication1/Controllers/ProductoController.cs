using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;
using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet("GetProducto", Name = "GetProducto")]
        public IEnumerable<Producto> Productos()
        {
            return ProductoBussiness.GetProductos();
        }

        [HttpGet("GetProductosPorId", Name = "GetProductosPorId")]
        public ActionResult<IEnumerable<Producto>> ObtenerProductoPorId(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Por favor introduzca un ID válido.");
            }

            var productos = ProductoBussiness.ObtenerProductoPorId(id);

            if (productos == null || productos.Count == 0)
            {
                return NotFound("No se encontraron productos con el ID proporcionado.");
            }

            return Ok(productos);
        }

        [HttpPost("AddProducto", Name = "AddProducto")]
        public ActionResult<string> Post([FromBody] Producto producto)
        {
            bool status = ProductoBussiness.CrearProducto(producto);
            if (!status)
            {
                return BadRequest("No se pudo crear el producto. El IdUsuario no existe.");
            }

            return Ok("Producto creado exitosamente");
        }

        [HttpPut("ModifyProducto", Name = "ModifyProducto")]
        public ActionResult<string> Put([FromBody] Producto producto)
        {
            if (producto.IdUsuario <= 0)
            {
                return BadRequest("El campo IdUsuario es obligatorio y debe ser mayor a 0.");
            }
            bool status = ProductoBussiness.ModificarProducto(producto);
            if (!status)
            {
                return BadRequest("No se pudo modificar el producto. El Id del producto no existe.");
            }

            return Ok("Producto modificado exitosamente");
        }

        [HttpDelete("DeleteProducto", Name = "DeleteProducto")]
        public ActionResult<string> Delete([FromBody] int id)
        {
            bool status = ProductoBussiness.EliminarProducto(id);
            if (!status)
            {
                return BadRequest("No se pudo eliminar el producto");
            }
            else
            {
                return Ok("Producto eliminado exitosamente");
            }
        }
    }
}
