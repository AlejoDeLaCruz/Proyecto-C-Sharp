using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Desafio_2.Models;
using System.Data;

namespace Desafio_2.DataBaseAccess
{
    internal class ProductoData
    {
        // METODO OBTENER
        public static List<Producto> ObtenerProducto(int idProducto)
        {
            List<Producto> lista = new List<Producto>();

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoCSharp;Trusted_connection=True;";

            var query = "SELECT * FROM Producto WHERE Id=@idProducto";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "idProducto";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = idProducto;

                    comando.Parameters.Add(parametro);

                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var producto = new Producto();
                                producto.Id = Convert.ToInt32(dr["Id"]);
                                producto.Descripcion = dr["Descripciones"].ToString();
                                producto.PrecioVenta = Convert.ToDouble(dr["PrecioVenta"]);
                                producto.Costo = Convert.ToDouble(dr["Costo"]);
                                producto.Stock = Convert.ToInt32(dr["Stock"]);
                                producto.Usuario = dr["IdUsuario"].ToString();
                                lista.Add(producto);
                            }
                        }
                    }
                }
            }
            return lista;
        }
    }
}
