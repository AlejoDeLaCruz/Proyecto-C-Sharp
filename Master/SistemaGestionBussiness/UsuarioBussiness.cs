using SistemaGestionEntities;
using SistemaGestionData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class UsuarioBussiness
    {
        public static List<Usuario> GetUsuarios()
        {
            return UsuarioData.GetUsuarios();
        }
        public static bool ModificarUsuario(Usuario usuario)
        {
            if (!UsuarioData.UsuarioExiste(usuario.Id))
            {
                return false;
            }
            return UsuarioData.ModificarUsuario(usuario);
        }
        public static List<Usuario> ObtenerUsuarioPorId(int id)
        {
            return UsuarioData.ObtenerUsuarioPorId(id);
        }
        public static bool CrearUsuario(Usuario usuario)
        {
            return UsuarioData.CrearUsuario(usuario);
        }
        public static bool EliminarUsuario(int id)
        {
            return UsuarioData.EliminarUsuario(id);
        }
    }
}
