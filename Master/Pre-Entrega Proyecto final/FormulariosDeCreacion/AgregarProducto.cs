using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pre_Entrega_Proyecto_final.FormulariosDeCreacion
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
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

        private void BotonCrear_Click(object sender, EventArgs e)
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
                MessageBox.Show("El valor ingresado para el stock no es válido.");
                return;
            }

            Producto nuevoProducto = new Producto(0, descripcion, precio, costo, stock, usuario);
            ProductoData dataAccess = new ProductoData();

            dataAccess.CrearProducto(nuevoProducto);
            MessageBox.Show("Producto creado con éxito");


            ProductoVista agregarProducto = new ProductoVista();
            agregarProducto.Show();
            this.Hide();
        }
    }
}
