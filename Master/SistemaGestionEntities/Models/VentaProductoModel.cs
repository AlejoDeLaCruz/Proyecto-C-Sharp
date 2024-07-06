using SistemaGestionEntities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities.Models
{
    public class VentaProductoModel
    {
        public Venta Venta { get; set; }
        public List<ProductoVendido> Productos { get; set; }
        public int IdUsuario { get; set; }
    }
}
