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
    public partial class UsuariosVista : Form
    {
        public UsuariosVista()
        {
            InitializeComponent();
        }

        private void UsuariosVista_Load(object sender, EventArgs e)
        {
            // Cargar usuarios al DataGridView al cargar el formulario
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            try
            {
                // Obtener usuarios desde la base de datos
                var usuarios = UsuarioData.GetUsuarios();

                // Asignar los usuarios al DataSource del DataGridView
                dataGridView1.DataSource = usuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                // Obtener los valores de las celdas en la fila seleccionada
                int idUsuario = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                string nombre = Convert.ToString(filaSeleccionada.Cells["Nombre"].Value);
                string apellido = Convert.ToString(filaSeleccionada.Cells["Apellido"].Value);
                string nombreUsuario = Convert.ToString(filaSeleccionada.Cells["NombreUsuario"].Value);
                string contraseña = Convert.ToString(filaSeleccionada.Cells["Contraseña"].Value);
                string mail = Convert.ToString(filaSeleccionada.Cells["Mail"].Value);

                // Modificar el usuario con los nuevos datos
                Usuario usuarioModificado = new Usuario(idUsuario, nombre, apellido, nombreUsuario, contraseña, mail);

                // Guardar el usuario modificado en la base de datos
                try
                {
                    UsuarioData.ModificarUsuario(usuarioModificado);
                    MessageBox.Show("Usuario modificado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar usuario: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para modificar.");
            }
            CargarUsuarios();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                int idUsuario = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                string nombre = Convert.ToString(filaSeleccionada.Cells["Nombre"].Value);
                string apellido = Convert.ToString(filaSeleccionada.Cells["Apellido"].Value);
                string nombreUsuario = Convert.ToString(filaSeleccionada.Cells["NombreUsuario"].Value);
                string contraseña = Convert.ToString(filaSeleccionada.Cells["Contraseña"].Value);
                string mail = Convert.ToString(filaSeleccionada.Cells["Mail"].Value);

                Usuario usuarioABorrar = new Usuario(idUsuario, nombre, apellido, nombreUsuario, contraseña, mail);

                try
                {
                    UsuarioData.EliminarUsuario(usuarioABorrar.Id);
                    MessageBox.Show("Usuario eliminado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar usuario: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.");
            }
            CargarUsuarios();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonVolver_click(object sender, EventArgs e)
        {
            ElegirInformacion elegirInformacionForm = new ElegirInformacion();
            elegirInformacionForm.Show();

            this.Hide(); 
        }
    }
}
