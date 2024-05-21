using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Windows_Froms_Proyecto_c_
{
    internal class UsuarioDataAccess
    {
        string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoCSharp;Trusted_Connection=True;";

        public void InsertarUsuario(Usuario usuario)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Usuario (Nombre, Apellido, NombreUsuario, Contraseña, Mail) VALUES (@Nombre, @Apellido, @NombreUsuario, @Contraseña, @Mail)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                        cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                        cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña); 
                        cmd.Parameters.AddWithValue("@Mail", (object)usuario.Mail);              
                        cmd.ExecuteNonQuery();
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Error al guardar el usuario: " + ex.Message);
                }
            }
        }
    }
}

