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

        [HttpGet("GetVentasPorId", Name = "GetVentasPorId")]
        public ActionResult<IEnumerable<Venta>> VentasPorId(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Por favor introduzca un ID válido.");
            }

            var ventas = VentaBussiness.GetVentasPorId(id);

            if (ventas == null || ventas.Count == 0)
            {
                return NotFound("No se encontraron ventas con el ID proporcionado.");
            }

            return Ok(ventas);
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

        [HttpPut("ModificarVenta", Name = "ModificarVenta")]
        public ActionResult<string> Put([FromBody] Venta venta)
        {
            try
            {
                if (venta.IdUsuario <= 0 || !UsuarioData.UsuarioExiste(venta.IdUsuario))
                {
                    return BadRequest("El IdUsuario no es válido.");
                }

                bool status = VentaBussiness.ModificarVenta(venta);

                if (!status)
                {
                    return BadRequest("No se pudo modificar la venta. Agregar un Id válido");
                }

                return Ok("Venta modificada exitosamente.");
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

        [HttpDelete("DeleteVenta/{id}", Name = "DeleteVenta")]
        public ActionResult<string> Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Por favor introduzca un ID válido.");
            }

            bool status = VentaBussiness.DeleteVenta(id);

            if (!status)
            {
                return BadRequest("No se pudo eliminar la venta");
            }

            return Ok("Se pudo eliminar la venta exitosamente");
        }
    }

    public class VentaProductoModel
    {
        public Venta Venta { get; set; }
        public List<ProductoVendido> Productos { get; set; }
        public int IdUsuario { get; set; }
    }
}
