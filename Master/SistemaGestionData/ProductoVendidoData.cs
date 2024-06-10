using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public class ProductoVendidoData
    {
        // METODO OBTENER PRODUCTO VENDIDO
        public static List<ProductoVendido> ObtenerProductoVendidoPorId(int idProductoVendido)
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoCSharp;Trusted_connection=True;";

            var query = "SELECT * FROM Producto WHERE Id=@idProductoVendido";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "idProductoVendido";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = idProductoVendido;

                    comando.Parameters.Add(parametro);

                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var productoVendido = new ProductoVendido();
                                productoVendido.Id = Convert.ToInt32(dr["Id"]);
                                productoVendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                productoVendido.Stock = Convert.ToInt32(dr["Stock"]);
                                productoVendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);
                                lista.Add(productoVendido);
                            }
                        }
                    }
                }
            }
            return lista;
        }

        //METODO LISTAR PRODUCTO VENDIDO
        public static List<ProductoVendido> GetProductosVendidos()
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoCSharp;Trusted_connection=True;";

            var query = "SELECT * FROM ProductoVendido";

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
                                var productoVendido = new ProductoVendido();
                                productoVendido.Id = Convert.ToInt32(dr["Id"]);
                                productoVendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                productoVendido.Stock = Convert.ToInt32(dr["Stock"]);
                                productoVendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);
                                lista.Add(productoVendido);
                            }
                        }
                    }
                }
            }
            return lista;
        }

        //METODO CREAR PRODUCTO VENDIDO
        public void CrearProductoVendido(ProductoVendido productoVendido)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoCSharp;Trusted_connection=True;";

            var query = "INSERT INTO ProductoVendido (IdProducto, Stock, IdVenta)" +
                        "VALUES (@IdProducto, @Stock, @IdVenta)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productoVendido.IdProducto });
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = productoVendido.Stock });
                    comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = productoVendido.IdVenta });
                    comando.ExecuteNonQuery();  
                }
            }
        }

        //METODO MODIFICAR PRODUCTO VENDIDO
        public void ModificarProductoVendido(ProductoVendido productoVendido)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoCSharp;Trusted_connection=True;";

            var query = "UPDATE ProductoVendido " +
                        "SET IdProducto = @IdProducto, " +
                        "Stock = @Stock, " +
                        "IdVenta = @IdVenta " +
                        "WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = productoVendido.Id });
                    comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productoVendido.IdProducto });
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = productoVendido.Stock });
                    comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = productoVendido.IdVenta });
                    comando.ExecuteNonQuery();
                }
            }
        }

        //METODO ELIMINAR PRODUCTO VENDIDO
        public void EliminarProductoVendido(ProductoVendido productoVendido)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoCSharp;Trusted_connection=True;";

            var query = "DELETE FROM ProductoVendido WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = productoVendido.Id });
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
