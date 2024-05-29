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
        public string Descripcion { get; set; }
        public double PrecioVenta { get; set; }
        public double Costo { get; set; }
        public int Stock { get; set; }
        public string Usuario { get; set; }
        public Producto() { }
        public Producto(int id, string descripcion, double precioVenta, double costo, int stock, string usuario)
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.PrecioVenta = precioVenta;
            this.Costo = costo;
            this.Stock = stock;
            this.Usuario = usuario;
        }
    }
}
