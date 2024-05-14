using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerDesafio
{
    internal class ProductoVendido
    {
        protected int Id { get; set; }
        protected int IdProducto { get; set; }
        protected int Stock { get; set; }
        protected int IdVenta { get; set; }

        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            this.Id = id;
            this.IdProducto = idProducto;
            this.Stock = stock;
            this.IdVenta = idVenta;
        }
    }
}
