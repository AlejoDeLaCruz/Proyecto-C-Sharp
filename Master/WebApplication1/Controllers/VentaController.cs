using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionData;
using SistemaGestionEntities;
using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {

        [HttpGet("GetVentas", Name = "GetVentas")]
        public IEnumerable<Venta> Ventas()
        {
            return VentaBussiness.GetVentas();
        }

        [HttpPost("CargarVenta", Name = "CargarVenta")]
        public ActionResult<string> Post([FromBody] VentaProductoModel ventaProductoModel)
        {
            if (ventaProductoModel.IdUsuario <= 0)
            {
                return BadRequest("El IdUsuario es obligatorio y debe ser mayor que cero.");
            }

            if (ventaProductoModel.Productos == null || ventaProductoModel.Productos.Count == 0)
            {
                return BadRequest("La lista de productos vendidos no puede estar vacía.");
            }

            foreach (var producto in ventaProductoModel.Productos)
            {
                if (producto.Stock <= 0)
                {
                    return BadRequest($"El stock del producto {producto.IdProducto} debe ser mayor que cero.");
                }

                if (producto.IdProducto <= 0 || !ProductoData.ProductoExiste(producto.IdProducto))
                {
                    return BadRequest($"El IdProducto {producto.IdProducto} no es válido.");
                }
            }

            try
            {
                bool status = VentaBussiness.CrearVenta(ventaProductoModel.Venta, ventaProductoModel.Productos, ventaProductoModel.IdUsuario);

                if (!status)
                {
                    return BadRequest("No se pudo crear la venta. Verifica que el IdUsuario y los Ids de Producto sean válidos.");
                }

                return Ok("Venta creada exitosamente.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor: " + ex.Message);
            }
        }
    }

    public class VentaProductoModel
    {
        public Venta Venta { get; set; }
        public List<ProductoVendido> Productos { get; set; }
        public int IdUsuario { get; set; }
    }
}
