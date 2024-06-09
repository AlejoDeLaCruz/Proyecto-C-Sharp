using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;
using SistemaGestionData;

namespace SistemaGestionBussiness
{
    internal class ProductoBussiness
    {
        public static List<Producto> GetProductos()
        {
            return ProductoData.GetProductos();
        }
    }
}
