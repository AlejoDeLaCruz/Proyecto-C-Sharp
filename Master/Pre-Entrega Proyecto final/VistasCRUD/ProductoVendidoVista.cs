using SistemaGestionEntities.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Pre_Entrega_Proyecto_final.ApiServices;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using Pre_Entrega_Proyecto_final.FormulariosDeCreacion;

namespace Pre_Entrega_Proyecto_final
{
    public partial class ProductoVendidoVista : Form
    {
        private readonly ApiService _apiService;

        public ProductoVendidoVista()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        private async void ProductoVendidoVista_Load(object sender, EventArgs e)
        {
            await CargarProductosVendidos();
        }

        private async Task CargarProductosVendidos()
        {
            try
            {
                var endpoint = "api/ProductoVendido/GetProductosVendidos";
                var response = await _apiService.GetDataAsync(endpoint);

                if (response != null)
                {
                    var productosVendidos = JsonConvert.DeserializeObject<List<ProductoVendido>>(response);
                    dataGridView1.DataSource = productosVendidos;
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la lista de productos vendidos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos vendidos: " + ex.Message);
            }
        }

        private async void ModificarButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                int idProductoVendido = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                int idProducto = Convert.ToInt32(filaSeleccionada.Cells["IdProducto"].Value);
                int nuevoStock = Convert.ToInt32(filaSeleccionada.Cells["Stock"].Value);
                int idVenta = Convert.ToInt32(filaSeleccionada.Cells["IdVenta"].Value);

                ProductoVendido producto = new ProductoVendido(idProductoVendido, idProducto, nuevoStock, idVenta);

                try
                {
                    var json = JsonConvert.SerializeObject(producto);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var endpoint = $"api/ProductoVendido/ModifyProductoVendido";
                    var response = await _apiService.PutDataAsync(endpoint, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Producto vendido modificado exitosamente");
                        await CargarProductosVendidos();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el producto vendido: " + response.ReasonPhrase);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el producto vendido: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un producto vendido para modificar.");
            }
        }

        private async void EliminarButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                int idProductoVendido = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);

                try
                {
                    var endpoint = $"api/ProductoVendido/DeleteProductosVendidos/{idProductoVendido}";
                    var response = await _apiService.DeleteDataAsync(endpoint);

                    if (response)
                    {
                        MessageBox.Show("Producto vendido eliminado exitosamente");
                        await CargarProductosVendidos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el producto vendido.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto vendido: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un producto vendido para eliminar.");
            }
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarProductoVendido agregarProductoVendido = new AgregarProductoVendido();
            agregarProductoVendido.Show();
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            ElegirInformacion elegirInformacionForm = new ElegirInformacion();
            elegirInformacionForm.Show();

            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (int.TryParse(textBox1.Text, out int idProductoVendido))
                {
                    await BuscarProductoVendidoPorId(idProductoVendido);
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido para el ID de Producto Vendido.");
                }
            }
            else
            {
                CargarProductosVendidos();
            }
        }

        private async Task BuscarProductoVendidoPorId(int idProductoVendido)
        {
            try
            {
                var endpoint = $"api/ProductoVendido/GetProductosVendidosPorId?id={idProductoVendido}";
                var response = await _apiService.GetDataAsync(endpoint);

                if (response != null)
                {
                    var productosVendidos = JsonConvert.DeserializeObject<List<ProductoVendido>>(response);
                    dataGridView1.DataSource = productosVendidos;
                }
                else
                {
                    MessageBox.Show($"No se encontró ningún producto vendido con el ID {idProductoVendido}.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar producto vendido por ID: {ex.Message}");
            }
        }
    }
}