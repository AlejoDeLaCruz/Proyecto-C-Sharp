using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities.Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripciones { get; set; }
        public double PrecioVenta { get; set; }
        public double Costo { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }
        public Producto() { }
        public Producto(int id, string descripciones, double precioVenta, double costo, int stock, int idUsuario)
        {
            Id = id;
            Descripciones = descripciones;
            PrecioVenta = precioVenta;
            Costo = costo;
            Stock = stock;
            IdUsuario = idUsuario;
        }
    }
}
