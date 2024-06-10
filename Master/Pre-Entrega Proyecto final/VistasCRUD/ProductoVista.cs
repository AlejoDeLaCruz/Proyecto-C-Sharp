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
    public partial class ProductoVista : Form
    {
        public ProductoVista()
        {
            InitializeComponent();
        }
        private void ProductoVista_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }
        private void modificarButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                // Obtener los valores de las celdas en la fila seleccionada
                int idProducto = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                string nuevasDescripciones = Convert.ToString(filaSeleccionada.Cells["Descripciones"].Value);
                double nuevoPrecioVenta = Convert.ToDouble(filaSeleccionada.Cells["PrecioVenta"].Value);
                double nuevoCosto = Convert.ToDouble(filaSeleccionada.Cells["Costo"].Value);
                int nuevoStock = Convert.ToInt32(filaSeleccionada.Cells["Stock"].Value);
                int idUsuario = Convert.ToInt32(filaSeleccionada.Cells["IdUsuario"].Value);


                Producto productoModificado = new Producto(idProducto, nuevasDescripciones, nuevoPrecioVenta, nuevoCosto, nuevoStock, idUsuario);

                // Guardar el usuario modificado en la base de datos
                try
                {
                    ProductoData dataAccess = new ProductoData();
                    dataAccess.ModificarProducto(productoModificado);
                    MessageBox.Show("producto modificado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar producto: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una producto para modificar.");
            }
            CargarProductos();
        }

        private void CargarProductos()
        {
            try
            {
                var productos = ProductoData.GetProductos();

                dataGridView1.DataSource = productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarProducto agregarProducto = new AgregarProducto();
            agregarProducto.Show();
        }

        private void EliminarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                // Obtener los valores de las celdas en la fila seleccionada
                int idProducto = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                string nuevasDescripciones = Convert.ToString(filaSeleccionada.Cells["Descripciones"].Value);
                double nuevoPrecioVenta = Convert.ToDouble(filaSeleccionada.Cells["PrecioVenta"].Value);
                double nuevoCosto = Convert.ToDouble(filaSeleccionada.Cells["Costo"].Value);
                int nuevoStock = Convert.ToInt32(filaSeleccionada.Cells["Stock"].Value);
                int idUsuario = Convert.ToInt32(filaSeleccionada.Cells["IdUsuario"].Value);


                Producto productoEliminado = new Producto(idProducto, nuevasDescripciones, nuevoPrecioVenta, nuevoCosto, nuevoStock, idUsuario);

                // Guardar el usuario modificado en la base de datos
                try
                {
                    ProductoData dataAccess = new ProductoData();
                    dataAccess.EliminarProducto(productoEliminado);
                    MessageBox.Show("producto eliminado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar producto: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una producto para eliminar.");
            }
            CargarProductos();
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
    }
}
