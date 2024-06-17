using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

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
                return BadRequest("No se pudo crear el producto. El IdUsuario no existe.");
            }

            return Ok("Producto creado exitosamente");
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
                return "producto eliminado exitosamente";
            }
        }
    }
}
