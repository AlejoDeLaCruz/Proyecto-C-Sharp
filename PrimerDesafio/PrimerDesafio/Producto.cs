using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerDesafio
{
    internal class Producto
    {
        protected int Id { get; set; }
        protected string Descripcion { get; set; }
        protected double PrecioVenta { get; set; }
        protected double Costo { get; set; }
        protected int Stock { get; set; }
        protected string Usuario { get; set; }

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
