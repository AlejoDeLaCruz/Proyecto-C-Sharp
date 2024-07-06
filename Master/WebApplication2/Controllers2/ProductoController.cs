using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities.Entidades;
using System.Collections.Generic;

namespace WebApplication2.Controllers2
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

        [HttpGet("GetProductosPorId/{id}", Name = "GetProductosPorId")]
        public ActionResult<IEnumerable<Producto>> ObtenerProductoPorId(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Por favor introduzca un ID válido.");
            }

            var productos = ProductoBussiness.ObtenerProductoPorId(id);

            if (productos == null)
            {
                return Ok(new List<Producto>()); 
            }

            return Ok(productos);
        }

        [HttpPost("AddProducto")]
        public IActionResult CrearProducto([FromBody] Producto producto)
        {
            if (producto == null || string.IsNullOrEmpty(producto.Descripciones) || producto.PrecioVenta < 0 || producto.Costo < 0 || producto.Stock < 0 || producto.IdUsuario <= 0)
            {
                return BadRequest("Datos del producto inválidos.");
            }

            try
            {
                bool isAdded = ProductoBussiness.CrearProducto(producto);
                if (isAdded)
                {
                    return Ok("Producto creado con éxito.");
                }
                else
                {
                    return BadRequest("Error al crear el producto.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor: " + ex.Message);
            }
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

        [HttpDelete("DeleteProducto/{id}", Name = "DeleteProducto")]
        public ActionResult<string> Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Por favor introduzca un ID válido.");
            }

            bool status = ProductoBussiness.EliminarProducto(id);
            if (!status)
            {
                return BadRequest("No se pudo eliminar el producto. El Id del producto no existe.");
            }

            return Ok("Producto eliminado exitosamente");
        }
    }
}