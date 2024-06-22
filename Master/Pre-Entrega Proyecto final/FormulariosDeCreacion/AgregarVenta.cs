using SistemaGestionBussiness;
using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pre_Entrega_Proyecto_final.FormulariosDeCreacion
{
    public partial class AgregarVenta : Form
    {
        private List<ProductoVendido> productosVendidos;

        public AgregarVenta()
        {
            InitializeComponent();
            productosVendidos = new List<ProductoVendido>();
        }

        private void AgregarVenta_Load(object sender, EventArgs e)
        {
        }

        private void BotonCrear_Click(object sender, EventArgs e)
        {
            string comentarios = ComentariosTxt.Text;
            int idDeUsuario;

            if (!int.TryParse(IdDeUsuarioTxt.Text, out idDeUsuario))
            {
                MessageBox.Show("El valor ingresado para el id de usuario no es válido.");
                return;
            }

            if (productosVendidos.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto.");
                return;
            }

            Venta nuevaVenta = new Venta
            {
                Comentarios = comentarios,
                IdUsuario = idDeUsuario
            };

            bool ventaCreada = VentaBussiness.CrearVenta(nuevaVenta, productosVendidos, idDeUsuario);

            if (ventaCreada)
            {
                MessageBox.Show("Venta creada con éxito");
                VentasVista ventaVista = new VentasVista();
                ventaVista.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se pudo crear la venta. Verifique los datos ingresados.");
            }
        }

        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            int productId;
            int cantidad;

            if (!int.TryParse(productIdTxt.Text, out productId) || productId <= 0)
            {
                MessageBox.Show("El valor ingresado para el Id del producto no es válido.");
                return;
            }

            if (!int.TryParse(cantidadDeProductosAComprarTxt.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("El valor ingresado para la cantidad de productos no es válido.");
                return;
            }

            ProductoVendido productoVendido = new ProductoVendido
            {
                IdProducto = productId,
                Stock = cantidad
            };

            productosVendidos.Add(productoVendido);
            MessageBox.Show($"Producto {productId} con cantidad {cantidad} agregado.");

            // Limpiar campos después de agregar
            productIdTxt.Clear();
            cantidadDeProductosAComprarTxt.Clear();
        }

        private void IdDeUsuarioTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void cantidadDeProductosAComprar_TextChanged(object sender, EventArgs e)
        {
        }

        private void productId_TextChanged(object sender, EventArgs e)
        {
        }

        private void ComentariosTxt_TextChanged(object sender, EventArgs e)
        {
        }
    }
}