using Newtonsoft.Json;
using Pre_Entrega_Proyecto_final.ApiServices;
using SistemaGestionEntities.Entidades;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Pre_Entrega_Proyecto_final.FormulariosDeCreacion
{
    public partial class AgregarProducto : Form
    {
        private ApiService apiService;

        public AgregarProducto()
        {
            InitializeComponent();
            apiService = new ApiService();
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DescripcionTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrecioTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CostoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void StockTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsuarioTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private async void BotonCrear_Click(object sender, EventArgs e)
        {
            string descripcion = DescripcionTxt.Text;
            double precio;
            double costo;
            int stock;
            int usuario;

            if (!double.TryParse(PrecioTxt.Text, out precio))
            {
                MessageBox.Show("El valor ingresado para el precio no es válido.");
                return;
            }

            if (!double.TryParse(CostoTxt.Text, out costo))
            {
                MessageBox.Show("El valor ingresado para el costo no es válido.");
                return;
            }
            if (!int.TryParse(StockTxt.Text, out stock))
            {
                MessageBox.Show("El valor ingresado para el stock no es válido.");
                return;
            }
            if (!int.TryParse(UsuarioTxt.Text, out usuario))
            {
                MessageBox.Show("El valor ingresado para el usuario no es válido.");
                return;
            }

            Producto nuevoProducto = new Producto(0, descripcion, precio, costo, stock, usuario);

            try
            {
                string json = JsonConvert.SerializeObject(nuevoProducto, Formatting.Indented);
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                Console.WriteLine("JSON Payload: " + json);

                var response = await apiService.PostDataAsync("api/Producto/AddProducto", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Producto creado con éxito");
                }
                else
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Error al crear producto: " + errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear producto: " + ex.Message);
            }

            ProductoVista productoVista = new ProductoVista();
            productoVista.Show();
            this.Hide();
        }
    }
}
