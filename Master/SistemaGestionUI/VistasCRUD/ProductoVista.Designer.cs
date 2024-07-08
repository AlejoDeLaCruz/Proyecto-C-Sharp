namespace Pre_Entrega_Proyecto_final
{
    partial class ProductoVista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AgregarProducto = new Button();
            ModificarProducto = new Button();
            EliminarProducto = new Button();
            VolverButton = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // AgregarProducto
            // 
            AgregarProducto.Location = new Point(452, 29);
            AgregarProducto.Name = "AgregarProducto";
            AgregarProducto.Size = new Size(92, 37);
            AgregarProducto.TabIndex = 0;
            AgregarProducto.Text = "Agregar";
            AgregarProducto.UseVisualStyleBackColor = true;
            AgregarProducto.Click += AgregarProducto_Click;
            // 
            // ModificarProducto
            // 
            ModificarProducto.Location = new Point(570, 29);
            ModificarProducto.Name = "ModificarProducto";
            ModificarProducto.Size = new Size(92, 37);
            ModificarProducto.TabIndex = 1;
            ModificarProducto.Text = "Modificar";
            ModificarProducto.UseVisualStyleBackColor = true;
            ModificarProducto.Click += modificarButton_Click;
            // 
            // EliminarProducto
            // 
            EliminarProducto.Location = new Point(686, 29);
            EliminarProducto.Name = "EliminarProducto";
            EliminarProducto.Size = new Size(92, 37);
            EliminarProducto.TabIndex = 2;
            EliminarProducto.Text = "Eliminar";
            EliminarProducto.UseVisualStyleBackColor = true;
            EliminarProducto.Click += EliminarProducto_Click;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(36, 29);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(92, 37);
            VolverButton.TabIndex = 3;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            VolverButton.Click += VolverButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 27;
            dataGridView1.Location = new Point(36, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 47;
            dataGridView1.Size = new Size(742, 337);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(319, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 26);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(152, 38);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 5;
            label1.Text = "Buscar producto por id";
            label1.Click += label1_Click;
            // 
            // ProductoVista
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(VolverButton);
            Controls.Add(EliminarProducto);
            Controls.Add(ModificarProducto);
            Controls.Add(AgregarProducto);
            Name = "ProductoVista";
            Text = "ProductoVista";
            Load += ProductoVista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AgregarProducto;
        private Button ModificarProducto;
        private Button EliminarProducto;
        private Button VolverButton;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
    }
}