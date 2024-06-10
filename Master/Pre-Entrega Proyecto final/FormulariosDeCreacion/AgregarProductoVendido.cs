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
    public partial class AgregarProductoVendido : Form
    {
        public AgregarProductoVendido()
        {
            InitializeComponent();
        }

        private void AgregarProductoVendido_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BotonCrear_Click(object sender, EventArgs e)
        {
            {
                int idProducto;
                int stock;
                int idVenta;

                if (!int.TryParse(idProductoTxt.Text, out idProducto))
                {
                    MessageBox.Show("El valor ingresado para el id de producto no es válido.");
                    return;
                }

                if (!int.TryParse(StockTxt.Text, out stock))
                {
                    MessageBox.Show("El valor ingresado para el stock no es válido.");
                    return;
                }
                if (!int.TryParse(IdDeVentaTxt.Text, out idVenta))
                {
                    MessageBox.Show("El valor ingresado para el id de venta no es válido.");
                    return;
                }

                ProductoVendido nuevoProductoVendido = new ProductoVendido(0, idProducto, stock, idVenta);
                ProductoVendidoData dataAccess = new ProductoVendidoData();

                dataAccess.CrearProductoVendido(nuevoProductoVendido);
                MessageBox.Show("Producto en venta creado con éxito");


                ProductoVendidoVista productoVendidoVista = new ProductoVendidoVista();
                productoVendidoVista.Show();
                this.Hide();
            }
        }

        private void idProductoTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
