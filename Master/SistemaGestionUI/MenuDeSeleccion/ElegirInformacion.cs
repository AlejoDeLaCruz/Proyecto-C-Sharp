using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pre_Entrega_Proyecto_final
{
    public partial class ElegirInformacion : Form
    {
        public ElegirInformacion()
        {
            InitializeComponent();
        }

        private void InfoSelection_Load(object sender, EventArgs e)
        {
        }

        private void productosVendidosClick(object sender, EventArgs e)
        {
            ProductoVendidoVista productoVendido = new ProductoVendidoVista();
            productoVendido.Show();

            this.Hide();
        }

        private void usuariosClick(object sender, EventArgs e)
        {
            UsuariosVista usuariosVista = new UsuariosVista();
            usuariosVista.Show();

            this.Hide();
        }

        private void ventasClick(object sender, EventArgs e)
        {
            VentasVista venta = new VentasVista();
            venta.Show();

            this.Hide();
        }

        private void productosClick(object sender, EventArgs e)
        {
            ProductoVista producto = new ProductoVista();
            producto.Show();

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
