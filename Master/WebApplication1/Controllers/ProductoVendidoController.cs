using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;
using System.Xml.Linq;

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

        [HttpDelete ("DeleteProductosVentidos", Name = "DeleteProductosVendidos")]
        public ActionResult<string> Delete([FromBody] int id)
        {
            bool status = ProductoVendidoBussiness.EliminarProductoVendido(id);
            if (!status)
            {
                return BadRequest("No se pudo eliminar el producto vendido");
            }
            else
            {
                return "producto vendido eliminado exitosamente";
            }
        }

        [HttpGet("GetProductosVendidosPorId", Name = "GetProductosVendidosPorId")]

        public IEnumerable<ProductoVendido> ProductosVendidosPorId(int id)
        {
            return ProductoVendidoBussiness.ObtenerProductoVendidoPorId(id);
        }

        [HttpPost("CreateProductoVendido", Name = "CreateProductoVendido")]

        public ActionResult<string> Post([FromBody] ProductoVendido productoVendido)
        {
            bool status = ProductoVendidoBussiness.CrearProductoVendido(productoVendido);
            if (!status)
            {
                return BadRequest("No se pudo crear el producto vendido");
            }
            else
            {
                return "producto vendido creado exitosamente";
            }
        }

        [HttpPut("ModifyProductoVendido", Name = "ModifyProductoVendido")]

        public ActionResult<string> Put([FromBody] ProductoVendido productoVendido)
        {
            bool status = ProductoVendidoBussiness.ModificarProductoVendido(productoVendido);
            if (!status)
            {
                return BadRequest("No se pudo modificar el producto vendido");
            }
            else
            {
                return "producto vendido modificado exitosamente";
            }
        }
    }
}
