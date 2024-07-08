using Newtonsoft.Json;
using Pre_Entrega_Proyecto_final.ApiServices;
using Pre_Entrega_Proyecto_final.FormulariosDeCreacion;
using SistemaGestionEntities.Entidades;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Pre_Entrega_Proyecto_final
{
    public partial class VentasVista : Form
    {
        private ApiService apiService;

        public VentasVista()
        {
            InitializeComponent();
            apiService = new ApiService();
        }

        private async void VentasVista_Load(object sender, EventArgs e)
        {
            await CargarVentas();
        }

        private async Task CargarVentas()
        {
            try
            {
                string result = await apiService.GetDataAsync("api/Venta/GetVentas");
                var ventas = JsonConvert.DeserializeObject<List<Venta>>(result);

                dataGridView1.DataSource = ventas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas: " + ex.Message);
            }
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                int idVenta = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);

                try
                {
                    await apiService.DeleteDataAsync($"api/Venta/DeleteVenta/{idVenta}");
                    MessageBox.Show("Venta eliminada con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar venta: " + ex.Message);
                }

                await CargarVentas();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una venta para eliminar.");
            }
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                int idVenta = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                string comentarios = Convert.ToString(filaSeleccionada.Cells["Comentarios"].Value);
                int idUsuario = Convert.ToInt32(filaSeleccionada.Cells["IdUsuario"].Value);

                Venta ventaModificada = new Venta(idVenta, comentarios, idUsuario);

                try
                {
                    string json = JsonConvert.SerializeObject(ventaModificada);
                    HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await apiService.PutDataAsync($"api/Venta/ModificarVenta", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Venta modificada con éxito");
                        await CargarVentas();
                    }
                    else
                    {
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Error al modificar venta: " + errorMessage);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar venta: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una venta para modificar.");
            }
        }


        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (int.TryParse(textBox1.Text, out int idVenta))
                {
                    await BuscarVentaPorId(idVenta);
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido para el ID de Venta.");
                }
            }
            else
            {
                await CargarVentas();
            }
        }

        private async Task BuscarVentaPorId(int idVenta)
        {
            try
            {
                var endpoint = $"api/Venta/GetVentasPorId?id={idVenta}";
                var response = await apiService.GetDataAsync(endpoint);

                if (response != null)
                {
                    try
                    {
                        var venta = JsonConvert.DeserializeObject<Venta>(response);
                        if (venta != null)
                        {
                            dataGridView1.DataSource = new List<Venta> { venta };
                        }
                        else
                        {
                            dataGridView1.DataSource = null;
                        }
                    }
                    catch (JsonSerializationException)
                    {
                        var ventas = JsonConvert.DeserializeObject<List<Venta>>(response);
                        if (ventas != null && ventas.Count > 0)
                        {
                            dataGridView1.DataSource = ventas;
                        }
                        else
                        {
                            dataGridView1.DataSource = null;
                        }
                    }
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar venta por ID: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarVenta agregarVenta = new AgregarVenta();
            agregarVenta.Show();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            ElegirInformacion elegirInformacionForm = new ElegirInformacion();
            elegirInformacionForm.Show();

            this.Hide();
        }
    }
}
