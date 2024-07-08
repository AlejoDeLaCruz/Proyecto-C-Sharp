namespace Pre_Entrega_Proyecto_final
{
    partial class UsuariosVista
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
            agregarButton = new Button();
            eliminarButton = new Button();
            modificarButton = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            buscarPorID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(394, 24);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(107, 34);
            agregarButton.TabIndex = 0;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(656, 24);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(107, 34);
            eliminarButton.TabIndex = 1;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(524, 24);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(107, 34);
            modificarButton.TabIndex = 2;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 47;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(730, 351);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(33, 24);
            button1.Name = "button1";
            button1.Size = new Size(107, 34);
            button1.TabIndex = 4;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += botonVolver_click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(162, 32);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 5;
            label1.Text = "Buscar por id:";
            label1.Click += label1_Click;
            // 
            // buscarPorID
            // 
            buscarPorID.Location = new Point(267, 29);
            buscarPorID.Name = "buscarPorID";
            buscarPorID.Size = new Size(116, 26);
            buscarPorID.TabIndex = 6;
            buscarPorID.TextChanged += buscarPorId;
            // 
            // UsuariosVista
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(800, 450);
            Controls.Add(buscarPorID);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            Controls.Add(agregarButton);
            Name = "UsuariosVista";
            Text = "s";
            Load += UsuariosVista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button agregarButton;
        private Button eliminarButton;
        private Button modificarButton;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private TextBox buscarPorID;
    }
}