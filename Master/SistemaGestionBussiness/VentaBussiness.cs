using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;

namespace SistemaGestionBussiness
{
    public class VentaBussiness
    {
        public static List<Venta> GetVentas()
        {
            return VentaData.GetVentas();
        }

        public static List<Venta> GetVentasPorId(int id)
        {
            return VentaData.ObtenerVentaPorId(id);
        }

        public static bool CrearVenta(Venta venta, List<ProductoVendido> productos, int idUsuario)
        {
            if (idUsuario <= 0 || !UsuarioData.UsuarioExiste(idUsuario))
            {
                throw new ArgumentException("El IdUsuario no es válido.");
            }
            List<string> erroresValidacion = new List<string>();

            foreach (var producto in productos)
            {
                if (producto.IdProducto <= 0 || !ProductoData.ProductoExiste(producto.IdProducto))
                {
                    erroresValidacion.Add($"El IdProducto {producto.IdProducto} no es válido.");
                }

                if (producto.Stock <= 0)
                {
                    erroresValidacion.Add($"El stock del producto {producto.IdProducto} debe ser mayor que cero.");
                }
            }

            if (erroresValidacion.Count > 0)
            {
                string mensajeErrores = string.Join("\n", erroresValidacion);
                throw new ArgumentException(mensajeErrores);
            }

            return VentaData.CrearVenta(venta, productos, idUsuario);
        }

        public static bool DeleteVenta(int id)
        { 
            return VentaData.EliminarVenta(id);
        }

        public static bool ModificarVenta(Venta venta)
        {
            if (venta.IdUsuario <= 0 || !UsuarioData.UsuarioExiste(venta.IdUsuario))
            {
                throw new ArgumentException("El IdUsuario no es válido.");
            }

            return VentaData.ModificarVenta(venta);
        }
    }
}
