using Newtonsoft.Json;
using Pre_Entrega_Proyecto_final.ApiServices;
using Pre_Entrega_Proyecto_final.FormulariosDeCreacion;
using SistemaGestionEntities.Entidades;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pre_Entrega_Proyecto_final
{
    public partial class ProductoVista : Form
    {
        private ApiService apiService;

        public ProductoVista()
        {
            InitializeComponent();
            apiService = new ApiService();
        }

        private async void ProductoVista_Load(object sender, EventArgs e)
        {
            await CargarProductos();
        }

        private async Task CargarProductos()
        {
            try
            {
                string result = await apiService.GetDataAsync("api/Producto/GetProducto");
                var productos = JsonConvert.DeserializeObject<List<Producto>>(result);

                dataGridView1.DataSource = productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                int idProducto = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                string nuevasDescripciones = Convert.ToString(filaSeleccionada.Cells["Descripciones"].Value);
                double nuevoPrecioVenta = Convert.ToDouble(filaSeleccionada.Cells["PrecioVenta"].Value);
                double nuevoCosto = Convert.ToDouble(filaSeleccionada.Cells["Costo"].Value);
                int nuevoStock = Convert.ToInt32(filaSeleccionada.Cells["Stock"].Value);
                int idUsuario = Convert.ToInt32(filaSeleccionada.Cells["IdUsuario"].Value);

                Producto productoModificado = new Producto(idProducto, nuevasDescripciones, nuevoPrecioVenta, nuevoCosto, nuevoStock, idUsuario);

                try
                {
                    string json = JsonConvert.SerializeObject(productoModificado);
                    HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                    await apiService.PutDataAsync($"api/Producto/ModifyProducto", content);
                    MessageBox.Show("Producto modificado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar producto: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para modificar.");
            }

            await CargarProductos();
        }

        private async void EliminarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                int idProducto = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);

                try
                {
                    await apiService.DeleteDataAsync($"api/Producto/DeleteProducto/{idProducto}");
                    MessageBox.Show("Producto eliminado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar producto: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.");
            }

            await CargarProductos();
        }

        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarProducto agregarProducto = new AgregarProducto();
            agregarProducto.Show();
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
            if (int.TryParse(textBox1.Text, out int idProducto) && idProducto > 0)
            {
                await BuscarProductoPorId(idProducto);
            }
            else
            {
                await CargarProductos(); 
            }
        }

        private async Task BuscarProductoPorId(int idProducto)
        { 
            try
            {
                var endpoint = $"api/Producto/GetProductosPorId/{idProducto}";
                var response = await apiService.GetDataAsync(endpoint);

                if (response != null)
                {
                    var productos = JsonConvert.DeserializeObject<List<Producto>>(response);
                    dataGridView1.DataSource = productos;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
