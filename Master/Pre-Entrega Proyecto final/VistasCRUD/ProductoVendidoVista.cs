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
    public partial class ProductoVendidoVista : Form
    {
        public ProductoVendidoVista()
        {
            InitializeComponent();
        }
        private void ProductoVendidoVista_Load(object sender, EventArgs e)
        {
            CargarProductosVendidos();
        }
        private void VolverButton_Click(object sender, EventArgs e)
        {
            ElegirInformacion elegirInformacionForm = new ElegirInformacion();
            elegirInformacionForm.Show();

            this.Hide();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarProductoVendido agregarProductoVendido = new AgregarProductoVendido();
            agregarProductoVendido.Show();
        }

        private void CargarProductosVendidos()
        {
            try
            {
                var productosVendidos = ProductoVendidoData.GetProductosVendidos();

                dataGridView1.DataSource = productosVendidos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos vendidos: " + ex.Message);
            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)
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
                    ProductoVendidoData dataAccess = new ProductoVendidoData();
                    dataAccess.ModificarProductoVendido(producto);
                    MessageBox.Show("Producto Vendido modificada con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar Producto Vendido: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un producto vendido para modificar.");
            }
            CargarProductosVendidos();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
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
                    ProductoVendidoData dataAccess = new ProductoVendidoData();
                    dataAccess.EliminarProductoVendido(producto);
                    MessageBox.Show("Producto Vendido modificada con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar Producto Vendido: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un producto vendido para modificar.");
            }
            CargarProductosVendidos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
