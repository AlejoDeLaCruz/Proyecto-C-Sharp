using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities.Entidades;
using System.Collections.Generic;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("GetUsuarios", Name = "GetUsuarios")]
        public IEnumerable<Usuario> GetUsuarios()
        {
            return UsuarioBussiness.GetUsuarios();
        }

        [HttpGet("GetUsuariosPorId", Name = "GetUsuariosPorId")]
        public ActionResult<IEnumerable<Usuario>> GetUsuariosPorId(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Por favor introduzca un ID válido.");
            }

            var usuarios = UsuarioBussiness.GetUsuariosPorId(id);

            if (usuarios == null || usuarios.Count == 0)
            {
                return Ok(new List<Usuario>());
            }

            return Ok(usuarios);
        }

        [HttpPost("AddUsuario", Name = "AddUsuario")]
        public ActionResult<string> Post([FromBody] Usuario usuario)
        {
            bool status = UsuarioBussiness.CrearUsuario(usuario);
            if (!status)
            {
                return BadRequest("No se pudo crear el usuario. El IdUsuario no existe.");
            }

            return Ok("Usuario creado exitosamente");
        }

        [HttpPut("ModifyUsuario", Name = "ModifyUsuario")]
        public ActionResult<string> Put([FromBody] Usuario usuario)
        {
            if (usuario.Id <= 0)
            {
                return BadRequest("El campo Id es obligatorio");
            }

            bool status = UsuarioBussiness.ModificarUsuario(usuario);
            if (!status)
            {
                return BadRequest("El usuario con el Id proporcionado no existe.");
            }

            return Ok("Usuario modificado exitosamente");
        }

        [HttpDelete("DeleteUsuario/{id}", Name = "DeleteUsuario")]
        public ActionResult<string> Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Por favor introduzca un ID válido.");
            }

            bool status = UsuarioBussiness.EliminarUsuario(id);
            if (!status)
            {
                return BadRequest("No se pudo eliminar el usuario");
            }

            return Ok("Usuario eliminado exitosamente");
        }
    }
}