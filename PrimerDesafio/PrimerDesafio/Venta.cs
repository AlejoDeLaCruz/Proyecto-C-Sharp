using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerDesafio
{
    internal class Venta
    {
        protected int Id { get; set; }
        protected string Comentarios { get; set; }
        protected string Usuario { get; set; }

        public Venta(int id, string comentarios, string usuario)
        {
            this.Id = id;
            this.Comentarios = comentarios;
            this.Usuario = usuario;
        }
    }
}
