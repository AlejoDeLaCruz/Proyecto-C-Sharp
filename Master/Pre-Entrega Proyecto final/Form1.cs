using SistemaGestionData; 
using SistemaGestionEntities.Entidades;
using System;
using System.Windows.Forms;

namespace Pre_Entrega_Proyecto_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = nombrePersona.Text;
            string apellido = apellidoPersona.Text;
            string nombreDeUsuario = nombreUsuarioPersona.Text;
            string email = emailPersona.Text;
            string contrasena = contraseniaPersona.Text;

            Usuario nuevoUsuario = new Usuario(0, nombre, apellido, nombreDeUsuario, email, contrasena);

            try
            {
                bool resultado = UsuarioData.CrearUsuario(nuevoUsuario);

                if (resultado)
                {
                    MessageBox.Show("Usuario creado con éxito");
                }
                else
                {
                    MessageBox.Show("No se pudo crear el usuario. Verifica los datos ingresados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear usuario: {ex.Message}");
            }
            ElegirInformacion elegirInformacionForm = new ElegirInformacion();
            elegirInformacionForm.Show();
            this.Hide();
        }
    }
}