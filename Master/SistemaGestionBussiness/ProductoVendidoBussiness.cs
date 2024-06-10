using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    internal class ProductoVendidoBussiness
    {
        public static List<ProductoVendido> GetProductosVendidos()
        {
            return ProductoVendido.GetProductosVendidos();
        }
    }
}
