using Pre_Entrega_Proyecto_final.FormulariosDeCreacion;
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

namespace Pre_Entrega_Proyecto_final
{
    public partial class VentasVista : Form
    {
        public VentasVista()
        {
            InitializeComponent();
        }

        private void VentasVista_Load(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void CargarVentas()
        {
            try
            {
                var ventas = VentaData.GetVentas();

                dataGridView1.DataSource = ventas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas: " + ex.Message);
            }
        }

        private void eliminarButton_Click(object sender, EventArgs e)
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
                    VentaData.EliminarVenta(ventaModificada.Id);
                    MessageBox.Show("Venta eliminada con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar Venta: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una Venta para eliminar.");
            }
            CargarVentas();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            ElegirInformacion elegirInformacionForm = new ElegirInformacion();
            elegirInformacionForm.Show();

            this.Hide();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarVenta agregarVenta = new AgregarVenta();
            agregarVenta.Show();
        }

        private void modificarButton_Click(object sender, EventArgs e)
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
                    VentaData.ModificarVenta(ventaModificada);
                    MessageBox.Show("Venta modificada con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar Venta: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una Venta para modificar.");
            }
            CargarVentas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
