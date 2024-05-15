using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerDesafio
{
    internal class Venta
    {

        private int _id;
        private string _comentarios;
        private string _usuario;

        //POSIBLES GETTERS Y SETTERS:

        //protected int Id { get; set; }
        //protected string Comentarios { get; set; }
        //protected string Usuario { get; set; }

        public Venta(int id, string comentarios, string usuario)
        {
            this._id = id;
            this._comentarios = comentarios;
            this._usuario = usuario;
        }
    }
}
