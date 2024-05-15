using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerDesafio
{
    internal class Producto
    {
        private int _id;
        private string _descripcion;
        private double _precioVentak;
        private double _costo;
        private int _stock;
        private string _usuario;

        //POSIBLES GETTERS Y SETTERS:

        //protected int Id { get; set; }
        //protected string Descripcion { get; set; }
        //protected double PrecioVenta { get; set; }
        //protected double Costo { get; set; }
        //protected int Stock { get; set; }
        //protected string Usuario { get; set; }

        public Producto(int id, string descripcion, double precioVenta, double costo, int stock, string usuario)
        {
            this._id = id;
            this._descripcion = descripcion;
            this._precioVentak = precioVenta;
            this._costo = costo;
            this._stock = stock;
            this._usuario = usuario;
        }
    }
}
