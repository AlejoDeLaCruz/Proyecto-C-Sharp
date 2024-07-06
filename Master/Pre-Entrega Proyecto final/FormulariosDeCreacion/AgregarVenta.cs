using Pre_Entrega_Proyecto_final.ApiServices;
using SistemaGestionBussiness;
using SistemaGestionEntities.Entidades;
using SistemaGestionEntities.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Pre_Entrega_Proyecto_final.FormulariosDeCreacion
{
    public partial class AgregarVenta : Form
    {
        private ApiService apiService;
        private List<ProductoVendido> productosVendidos;

        public AgregarVenta()
        {
            InitializeComponent();
            apiService = new ApiService();
            productosVendidos = new List<ProductoVendido>();
        }

        private void AgregarVenta_Load(object sender, EventArgs e)
        {
        }

        private async void BotonCrear_Click(object sender, EventArgs e)
        {
            string comentarios = ComentariosTxt.Text;
            int idDeUsuario;

            if (!int.TryParse(IdDeUsuarioTxt.Text, out idDeUsuario))
            {
                MessageBox.Show("El valor ingresado para el id de usuario no es válido.");
                return;
            }

            if (productosVendidos.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto.");
                return;
            }

            Venta nuevaVenta = new Venta
            {
                Comentarios = comentarios,
                IdUsuario = idDeUsuario
            };

            VentaProductoModel ventaProductoModel = new VentaProductoModel
            {
                Venta = nuevaVenta,
                Productos = productosVendidos,
                IdUsuario = idDeUsuario
            };

            try
            {
                string json = JsonConvert.SerializeObject(ventaProductoModel);
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await apiService.PostDataAsync("api/Venta/CargarVenta", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Venta creada con éxito");
                    VentasVista ventaVista = new VentasVista();
                    ventaVista.Show();
                    this.Hide();
                }
                else
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Error al crear venta: " + errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear venta: " + ex.Message);
            }
        }

        private async void AgregarProducto_Click(object sender, EventArgs e)
        {
            int productId;
            int cantidad;

            if (!int.TryParse(productIdTxt.Text, out productId) || productId <= 0)
            {
                MessageBox.Show("El valor ingresado para el Id del producto no es válido.");
                return;
            }

            if (!int.TryParse(cantidadDeProductosAComprarTxt.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("El valor ingresado para la cantidad de productos no es válido.");
                return;
            }
            try
            {
                string result = await apiService.GetDataAsync($"api/Producto/GetProductosPorId/{productId}");

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show($"El producto con ID {productId} no existe.");
                }
                else
                {
                    ProductoVendido productoVendido = new ProductoVendido
                    {
                        IdProducto = productId,
                        Stock = cantidad
                    };

                    productosVendidos.Add(productoVendido);
                    MessageBox.Show($"Producto {productId} con cantidad {cantidad} agregado.");
                }
            }
            catch (Exception ex)
            {
                if (ex is HttpRequestException && ((HttpRequestException)ex).StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show($"El producto con ID {productId} no existe.");
                }
                else
                {
                    MessageBox.Show($"Error al verificar el producto: {ex.Message}");
                }
            }
        }

        private void IdDeUsuarioTxt_TextChanged(object sender, EventArgs e) { }
        private void ComentariosTxt_TextChanged(object sender, EventArgs e) { }
        private void cantidadDeProductosAComprar_TextChanged(object sender, EventArgs e) { }
        private void productId_TextChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}