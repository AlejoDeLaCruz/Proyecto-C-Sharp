using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SistemaGestionEntities;
using System.Collections;

namespace SistemaGestionData
{
    public class VentaData
    {
        // METODO OBTENER VENTA
        public static List<Venta> ObtenerVentaPorId(int idVenta)
        {
            List<Venta> lista = new List<Venta>();

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoCSharp;Trusted_connection=True;";

            var query = "SELECT * FROM Venta WHERE Id=@idVenta";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "idVenta";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = idVenta;

                    comando.Parameters.Add(parametro);

                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var producto = new Venta();
                                producto.Id = Convert.ToInt32(dr["Id"]);
                                producto.Comentarios = dr["Comentarios"].ToString();
                                producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                lista.Add(producto);
                            }
                        }
                    }
                }
            }
            return lista;
        }

        //METODO LISTAR VENTA
        public static List<Venta> GetVentas()
        {
            List<Venta> lista = new List<Venta>();

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoCSharp;Trusted_connection=True;";

            var query = "SELECT * FROM Venta";

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
                                var producto = new Venta();
                                producto.Id = Convert.ToInt32(dr["Id"]);
                                producto.Comentarios = dr["Comentarios"].ToString();
                                producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                lista.Add(producto);
                            }
                        }
                    }
                }
            }
            return lista;
        }

        //METODO CREAR VENTA
        public static bool CrearVenta(Venta venta, List<ProductoVendido> productos, int idUsuario)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoCSharp;Trusted_connection=True;";

            var queryVenta = "INSERT INTO Venta (Comentarios, IdUsuario) " +
                             "VALUES (@Comentarios, @IdUsuario); SELECT SCOPE_IDENTITY();";

            var queryProductosVendidos = "INSERT INTO ProductoVendido (IdVenta, IdProducto, Stock) " +
                                         "VALUES (@IdVenta, @IdProducto, @Stock);";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                SqlTransaction transaction = conexion.BeginTransaction();

                try
                {
                    int idVenta;
                    using (SqlCommand comandoVenta = new SqlCommand(queryVenta, conexion, transaction))
                    {
                        comandoVenta.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                        comandoVenta.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = idUsuario });
                        idVenta = Convert.ToInt32(comandoVenta.ExecuteScalar());
                    }

                    foreach (var producto in productos)
                    {
                        using (SqlCommand comandoProductosVendidos = new SqlCommand(queryProductosVendidos, conexion, transaction))
                        {
                            comandoProductosVendidos.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = idVenta });
                            comandoProductosVendidos.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = producto.IdProducto });
                            comandoProductosVendidos.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock });

                            comandoProductosVendidos.ExecuteNonQuery();
                        }

                        ActualizarStockProducto(conexion, transaction, producto.IdProducto, producto.Stock);
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al crear la venta. Detalles: " + ex.Message);
                }
            }
        }

        //METODO ACTUALIZAR STOCK DE PRODUCTOS
        public static bool ActualizarStockProducto(SqlConnection conexion, SqlTransaction transaction, int idProducto, int stock)
        {
            var queryActualizarStock = "UPDATE Producto SET Stock = Stock - @Stock WHERE Id = @IdProducto";

            using (SqlCommand comandoActualizarStock = new SqlCommand(queryActualizarStock, conexion, transaction))
            {
                comandoActualizarStock.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = stock });
                comandoActualizarStock.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = idProducto });

                return comandoActualizarStock.ExecuteNonQuery() > 0;
            }
        }

    //METODO MODIFICAR VENTA
    public static bool ModificarVenta(Venta venta)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoCSharp;Trusted_connection=True;";

            var query = "UPDATE Venta " +
                        "SET Comentarios = @Comentarios, " +
                        "IdUsuario = @IdUsuario " +
                        "WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = venta.Id });
                    comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = venta.IdUsuario });

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }


        //METODO ELIMINAR VENTA
        public static bool EliminarVenta(int id)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoCSharp;Trusted_connection=True;";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlTransaction transaction = conexion.BeginTransaction())
                {
                    try
                    {
                        // Primero eliminar los productos vendidos relacionados
                        var queryEliminarProductosVendidos = "DELETE FROM ProductoVendido WHERE IdVenta = @IdVenta";
                        using (SqlCommand comandoEliminarProductosVendidos = new SqlCommand(queryEliminarProductosVendidos, conexion, transaction))
                        {
                            comandoEliminarProductosVendidos.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = id });
                            comandoEliminarProductosVendidos.ExecuteNonQuery();
                        }

                        // Luego eliminar la venta
                        var queryEliminarVenta = "DELETE FROM Venta WHERE Id = @Id";
                        using (SqlCommand comandoEliminarVenta = new SqlCommand(queryEliminarVenta, conexion, transaction))
                        {
                            comandoEliminarVenta.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = id });
                            return comandoEliminarVenta.ExecuteNonQuery() > 0;
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Error al eliminar Venta", ex);
                    }
                }
            }
        }
    }
}
