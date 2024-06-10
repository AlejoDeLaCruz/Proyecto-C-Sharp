using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    internal class VentaBussiness
    {
        public static List<Venta> GetVentas()
        {
            return VentaData.GetVentas();
        }
    }
}
