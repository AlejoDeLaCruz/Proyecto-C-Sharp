using SistemaGestionEntities;
using SistemaGestionData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    internal class UsuarioBussiness
    {
        public static List<Usuario> GetUsuarios()
        {
            return UsuarioData.GetUsuarios();
        }
    }
}
