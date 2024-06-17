using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;
using SistemaGestionData;

namespace SistemaGestionBussiness
{
    public class ProductoBussiness
    {
        public static List<Producto> ObtenerProductoPorId(int id)
        {
            return ProductoData.ObtenerProductoPorId(id);
        }
        public static List<Producto> GetProductos()
        {
            return ProductoData.GetProductos();
        }
        public static bool CrearProducto(Producto producto)
        {
            return ProductoData.CrearProducto(producto);
        }
        public static bool EliminarProducto(int id)
        {
            return ProductoData.EliminarProducto(id);
        }
        public static bool ModificarProducto(Producto producto)
        {
            if (!UsuarioData.UsuarioExiste(producto.IdUsuario))
            {
                return false;
            }
            return ProductoData.ModificarProducto(producto);
        }
    }
}
