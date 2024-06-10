namespace Pre_Entrega_Proyecto_final
{
    partial class VentasVista
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(436, 23);
            button1.Name = "button1";
            button1.Size = new Size(99, 31);
            button1.TabIndex = 0;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += agregarButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(673, 23);
            button2.Name = "button2";
            button2.Size = new Size(87, 31);
            button2.TabIndex = 1;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += eliminarButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(563, 23);
            button3.Name = "button3";
            button3.Size = new Size(87, 31);
            button3.TabIndex = 2;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += modificarButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(32, 23);
            button4.Name = "button4";
            button4.Size = new Size(87, 31);
            button4.TabIndex = 3;
            button4.Text = "Volver";
            button4.UseVisualStyleBackColor = true;
            button4.Click += botonVolver_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 47;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(728, 347);
            dataGridView1.TabIndex = 4;
            // 
            // VentasVista
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "VentasVista";
            Text = "VentasVista";
            Load += VentasVista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
    }
}