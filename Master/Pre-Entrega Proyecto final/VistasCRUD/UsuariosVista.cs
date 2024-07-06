using Newtonsoft.Json;
using Pre_Entrega_Proyecto_final.ApiServices;
using SistemaGestionEntities.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pre_Entrega_Proyecto_final
{
    public partial class UsuariosVista : Form
    {
        private readonly ApiService _apiService;

        public UsuariosVista()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        private async void UsuariosVista_Load(object sender, EventArgs e)
        {
            await CargarUsuarios();
        }

        private async Task CargarUsuarios()
        {
            try
            {
                var endpoint = "api/Usuario/GetUsuarios";
                var response = await _apiService.GetDataAsync(endpoint);

                if (response != null)
                {
                    var usuarios = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Usuario>>(response);
                    dataGridView1.DataSource = usuarios;
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la lista de usuarios.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }

        private async void modificarButton_Click(object sender, EventArgs e)
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

                Usuario usuarioModificado = new Usuario(idUsuario, nombre, apellido, nombreUsuario, contraseña, mail);

                try
                {
                    string json = JsonConvert.SerializeObject(usuarioModificado);
                    HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await _apiService.PutDataAsync($"api/Usuario/ModifyUsuario", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Usuario modificado con éxito");
                        await CargarUsuarios();
                    }
                    else
                    {
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error al modificar usuario: {errorMessage}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar usuario: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para modificar.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                int idUsuario = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);

                var endpoint = $"api/Usuario/DeleteUsuario/{idUsuario}";
                var response = await _apiService.DeleteDataAsync(endpoint + $"?id={idUsuario}");

                if (response)
                {
                    MessageBox.Show("Usuario eliminado con éxito.");
                    await CargarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.");
            }
        }

        private void botonVolver_click(object sender, EventArgs e)
        {
            ElegirInformacion elegirInformacionForm = new ElegirInformacion();
            elegirInformacionForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void buscarPorId(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(buscarPorID.Text))
            {
                if (int.TryParse(buscarPorID.Text, out int idUsuario))
                {
                    await CargarUsuarioPorId(idUsuario);
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido para el ID.");
                }
            }
            else
            {
                await CargarUsuarios();
            }
        }

        private async Task CargarUsuarioPorId(int idUsuario)
        {
            try
            {
                var endpoint = $"api/Usuario/GetUsuariosPorId?id={idUsuario}";
                var response = await _apiService.GetDataAsync(endpoint);

                if (response != null)
                {
                    var usuarios = JsonConvert.DeserializeObject<List<Usuario>>(response);

                    if (usuarios != null && usuarios.Count > 0)
                    {
                        dataGridView1.DataSource = new List<Usuario> { usuarios[0] };
                    }
                    else
                    {
                        dataGridView1.DataSource = null;
                    }
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuario por ID: {ex.Message}");
            }
        }
    }
}