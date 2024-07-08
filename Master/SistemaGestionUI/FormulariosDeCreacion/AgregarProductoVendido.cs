using SistemaGestionEntities.Entidades;
using SistemaGestionData;
using Pre_Entrega_Proyecto_final.ApiServices;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pre_Entrega_Proyecto_final.FormulariosDeCreacion
{
    public partial class AgregarProductoVendido : Form
    {
        private readonly ApiService _apiService;

        public AgregarProductoVendido()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }
        private void idProductoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarProductoVendido_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private async void BotonCrear_Click(object sender, EventArgs e)
        {
            int idProducto;
            int stock;
            int idVenta;

            if (!int.TryParse(idProductoTxt.Text, out idProducto) || idProducto <= 0)
            {
                MessageBox.Show("El valor ingresado para el id de producto no es válido.");
                return;
            }

            if (!int.TryParse(StockTxt.Text, out stock) || stock <= 0)
            {
                MessageBox.Show("El valor ingresado para el stock no es válido.");
                return;
            }

            if (!int.TryParse(IdDeVentaTxt.Text, out idVenta) || idVenta <= 0)
            {
                MessageBox.Show("El valor ingresado para el id de venta no es válido.");
                return;
            }
            try
            {
                string resultProducto = await _apiService.GetDataAsync($"api/Producto/GetProductosPorId/{idProducto}");
                var productos = JsonConvert.DeserializeObject<List<Producto>>(resultProducto);
                if (productos == null || productos.Count == 0)
                {
                    MessageBox.Show($"El producto con ID {idProducto} no existe.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar el producto: {ex.Message}");
                return;
            }
            try
            {
                string resultVenta = await _apiService.GetDataAsync($"api/Venta/GetVentasPorId?id={idVenta}");
                var ventas = JsonConvert.DeserializeObject<List<Venta>>(resultVenta);
                if (ventas == null || ventas.Count == 0)
                {
                    MessageBox.Show($"La venta con ID {idVenta} no existe.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar la venta: {ex.Message}");
                return;
            }

            ProductoVendido nuevoProductoVendido = new ProductoVendido(0, idProducto, stock, idVenta);

            try
            {
                string json = JsonConvert.SerializeObject(nuevoProductoVendido);
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                var endpoint = "api/ProductoVendido/CreateProductoVendido";
                var response = await _apiService.PostDataAsync(endpoint, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Producto vendido creado exitosamente.");

                    ProductoVendidoVista productoVendidoVista = new ProductoVendidoVista();
                    productoVendidoVista.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error al crear producto vendido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear producto vendido: " + ex.Message);
            }
        }
    }
}