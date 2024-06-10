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
    public partial class AgregarVenta : Form
    {
        public AgregarVenta()
        {
            InitializeComponent();
        }

        private void AgregarVenta_Load(object sender, EventArgs e)
        {

        }

        private void BotonCrear_Click(object sender, EventArgs e)
        {
            {
                string comentarios = ComentariosTxt.Text;
                int idDeUsuario;

                if (!int.TryParse(IdDeUsuarioTxt.Text, out idDeUsuario))
                {
                    MessageBox.Show("El valor ingresado para el id de usuario no es válido.");
                    return;
                }

                Venta nuevaVenta = new Venta(0, comentarios, idDeUsuario);
                VentaData dataAccess = new VentaData();

                dataAccess.CrearVenta(nuevaVenta);
                MessageBox.Show("venta creada con éxito");


                VentasVista ventaVista = new VentasVista();
                ventaVista.Show();
                this.Hide();
            }
        }
    }
}
