using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerDesafio
{
    internal class Usuario
    {

        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private string _contraseña;
        private string _mail;

        //POSIBLES GETTERS Y SETTERS:

        //protected int Id { get; set; }
        //protected string Nombre { get; set; }
        //protected string Apellido { get; set; }
        //protected string NombreUsuario { get; set; }
        //protected string Contraseña { get; set; }
        //protected string Mail { get; set; }
        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contraseña, string mail)
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._nombreUsuario = nombreUsuario;
            this._contraseña = contraseña;
            this._mail = mail;
        }

    }
}
