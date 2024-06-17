using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemaGestionEntities;
using System.Data;

namespace SistemaGestionData
{
    public class ProductoData
    {
        // METODO OBTENER PRODUCTOS
        public static List<Producto> ObtenerProductoPorId(int idProducto)
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
                                producto.Descripciones = dr["Descripciones"].ToString();
                                producto.PrecioVenta = Convert.ToDouble(dr["PrecioVenta"]);
                                producto.Costo = Convert.ToDouble(dr["Costo"]);
                                producto.Stock = Convert.ToInt32(dr["Stock"]);
                                producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                lista.Add(producto);
                            }
                        }
                    }
                }
            }
            return lista;
        }

        //METODO LISTAR PRODUCTOS
        public static List<Producto> GetProductos()
        {
            List<Producto> lista = new List<Producto>();

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoCSharp;Trusted_connection=True;";

            var query = "SELECT * FROM Producto";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var producto = new Producto();
                                producto.Id = Convert.ToInt32(dr["Id"]);
                                producto.Descripciones = dr["Descripciones"].ToString();
                                producto.PrecioVenta = Convert.ToDouble(dr["PrecioVenta"]);
                                producto.Costo = Convert.ToDouble(dr["Costo"]);
                                producto.Stock = Convert.ToInt32(dr["Stock"]);
                                producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                lista.Add(producto);
                            }
                        }
                    }
                }
            }
            return lista;
        }


        //METODO CREAR PRODUCTO
        public static bool CrearProducto(Producto producto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoCSharp;Trusted_connection=True;";

            var query = "INSERT INTO Producto (Descripciones, PrecioVenta, Costo, Stock, IdUsuario)" +
                        "VALUES (@Descripciones, @PrecioVenta, @Costo, @Stock, @IdUsuario)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = producto.Descripciones });
                    comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Money) { Value = producto.PrecioVenta });
                    comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Money) { Value = producto.Costo });
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = producto.IdUsuario });
                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        //METODO MODIFICAR PRODUCTO
        public static bool ModificarProducto(Producto producto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoCSharp;Trusted_connection=True;";

            var query = "UPDATE Producto " +
                        "SET Descripciones = @Descripciones, " +
                        "PrecioVenta = @PrecioVenta, " +
                        "Costo = @Costo, " +
                        "Stock = @Stock, " +
                        "IdUsuario = @IdUsuario " +
                        "WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.Id });
                    comando.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = producto.Descripciones });
                    comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Money) { Value = producto.PrecioVenta });
                    comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Money) { Value = producto.Costo });
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = producto.IdUsuario });
                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        //METODO ELIMINAR PRODUCTO

        public static bool EliminarProducto(int id)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoCSharp;Trusted_connection=True;";

            var query = "DELETE FROM Producto WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = id });
                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool ProductoExiste(int idProducto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoCSharp;Trusted_connection=True;";

            var query = "SELECT COUNT(1) FROM Producto WHERE Id = @IdProducto";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = idProducto });
                    return (int)comando.ExecuteScalar() > 0;
                }
            }
        }
    }
}
