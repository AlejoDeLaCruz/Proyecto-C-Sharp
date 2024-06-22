namespace Pre_Entrega_Proyecto_final.FormulariosDeCreacion
{
    partial class AgregarVenta
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
            IdDeUsuarioTxt = new TextBox();
            ComentariosTxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BotonCrear = new Button();
            label7 = new Label();
            ProductId = new Label();
            cantidadDeProductosAComprarTxt = new TextBox();
            productIdTxt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            AgregarProductoBtn = new Button();
            SuspendLayout();
            // 
            // IdDeUsuarioTxt
            // 
            IdDeUsuarioTxt.Location = new Point(420, 299);
            IdDeUsuarioTxt.Name = "IdDeUsuarioTxt";
            IdDeUsuarioTxt.Size = new Size(250, 26);
            IdDeUsuarioTxt.TabIndex = 29;
            IdDeUsuarioTxt.TextChanged += IdDeUsuarioTxt_TextChanged;
            // 
            // ComentariosTxt
            // 
            ComentariosTxt.Location = new Point(420, 156);
            ComentariosTxt.Name = "ComentariosTxt";
            ComentariosTxt.Size = new Size(250, 26);
            ComentariosTxt.TabIndex = 28;
            ComentariosTxt.TextChanged += ComentariosTxt_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(175, 293);
            label3.Name = "label3";
            label3.Size = new Size(155, 32);
            label3.TabIndex = 24;
            label3.Text = "Id de Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(175, 149);
            label2.Name = "label2";
            label2.Size = new Size(149, 32);
            label2.TabIndex = 23;
            label2.Text = "Comentarios";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(285, 40);
            label1.Name = "label1";
            label1.Size = new Size(211, 42);
            label1.TabIndex = 22;
            label1.Text = "CREAR VENTA";
            // 
            // BotonCrear
            // 
            BotonCrear.Location = new Point(661, 388);
            BotonCrear.Name = "BotonCrear";
            BotonCrear.Size = new Size(101, 34);
            BotonCrear.TabIndex = 33;
            BotonCrear.Text = "Crear";
            BotonCrear.UseVisualStyleBackColor = true;
            BotonCrear.Click += BotonCrear_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(457, 328);
            label7.Name = "label7";
            label7.Size = new Size(192, 20);
            label7.TabIndex = 34;
            label7.Text = "El id de usuario debe existir";
            // 
            // ProductId
            // 
            ProductId.AutoSize = true;
            ProductId.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ProductId.ForeColor = Color.Transparent;
            ProductId.Location = new Point(175, 193);
            ProductId.Name = "ProductId";
            ProductId.Size = new Size(177, 32);
            ProductId.TabIndex = 35;
            ProductId.Text = "Id del Producto";
            // 
            // cantidadDeProductosAComprarTxt
            // 
            cantidadDeProductosAComprarTxt.Location = new Point(538, 251);
            cantidadDeProductosAComprarTxt.Name = "cantidadDeProductosAComprarTxt";
            cantidadDeProductosAComprarTxt.Size = new Size(132, 26);
            cantidadDeProductosAComprarTxt.TabIndex = 36;
            cantidadDeProductosAComprarTxt.TextChanged += cantidadDeProductosAComprar_TextChanged;
            // 
            // productIdTxt
            // 
            productIdTxt.Location = new Point(420, 199);
            productIdTxt.Name = "productIdTxt";
            productIdTxt.Size = new Size(250, 26);
            productIdTxt.TabIndex = 37;
            productIdTxt.TextChanged += productId_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(175, 244);
            label4.Name = "label4";
            label4.Size = new Size(361, 32);
            label4.TabIndex = 38;
            label4.Text = "Cantidad de productos vendidos";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(457, 228);
            label5.Name = "label5";
            label5.Size = new Size(205, 20);
            label5.TabIndex = 39;
            label5.Text = "El id de producto debe existir";
            // 
            // AgregarProductoBtn
            // 
            AgregarProductoBtn.Location = new Point(680, 250);
            AgregarProductoBtn.Name = "AgregarProductoBtn";
            AgregarProductoBtn.Size = new Size(75, 27);
            AgregarProductoBtn.TabIndex = 40;
            AgregarProductoBtn.Text = "Agregar Producto";
            AgregarProductoBtn.UseVisualStyleBackColor = true;
            AgregarProductoBtn.Click += AgregarProducto_Click;
            // 
            // AgregarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(800, 450);
            Controls.Add(AgregarProductoBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(productIdTxt);
            Controls.Add(cantidadDeProductosAComprarTxt);
            Controls.Add(ProductId);
            Controls.Add(label7);
            Controls.Add(BotonCrear);
            Controls.Add(IdDeUsuarioTxt);
            Controls.Add(ComentariosTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarVenta";
            Load += AgregarVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox IdDeUsuarioTxt;
        private TextBox ComentariosTxt;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BotonCrear;
        private Label label7;
        private Label ProductId;
        private TextBox cantidadDeProductosAComprarTxt;
        private TextBox productIdTxt;
        private Label label4;
        private Label label5;
        private Button AgregarProductoBtn; // Declaración del botón
    }
}