using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2.Models
{
    internal class Producto
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
            this.Id = id;
            this.Descripciones = descripciones;
            this.PrecioVenta = precioVenta;
            this.Costo = costo;
            this.Stock = stock;
            this.IdUsuario = idUsuario;
        }
    }
}
