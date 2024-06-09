using SistemaGestionData;
using SistemaGestionEntities;

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

            // Crear un nuevo usuario con los datos ingresados
            Usuario nuevoUsuario = new Usuario(0, nombre, apellido, nombreDeUsuario, email, contrasena);

            // Guardar el usuario en la base de datos
            UsuarioData dataAccess = new UsuarioData();
            dataAccess.CrearUsuario(nuevoUsuario);

            MessageBox.Show("Usuario y contraseña guardados con éxito");

            //Pasar a la pagina de informacion
            ElegirInformacion elegirInformacionForm = new ElegirInformacion();
            elegirInformacionForm.Show();

            // Cerrar el formulario actual (opcional)
            this.Hide(); // O puedes usar this.Close() si quieres cerrar completamente el formulario actual
        }
    }
}