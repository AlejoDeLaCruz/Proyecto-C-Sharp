namespace Pre_Entrega_Proyecto_final.FormulariosDeCreacion
{
    partial class AgregarProducto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            DescripcionTxt = new TextBox();
            PrecioTxt = new TextBox();
            CostoTxt = new TextBox();
            StockTxt = new TextBox();
            UsuarioTxt = new TextBox();
            BotonCrear = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(281, 51);
            label1.Name = "label1";
            label1.Size = new Size(278, 42);
            label1.TabIndex = 0;
            label1.Text = "CREAR PRODUCTO";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(203, 124);
            label2.Name = "label2";
            label2.Size = new Size(138, 32);
            label2.TabIndex = 1;
            label2.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(203, 177);
            label3.Name = "label3";
            label3.Size = new Size(79, 32);
            label3.TabIndex = 2;
            label3.Text = "Precio";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(203, 221);
            label4.Name = "label4";
            label4.Size = new Size(75, 32);
            label4.TabIndex = 3;
            label4.Text = "Costo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(203, 268);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 4;
            label5.Text = "Stock";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(203, 315);
            label6.Name = "label6";
            label6.Size = new Size(155, 32);
            label6.TabIndex = 5;
            label6.Text = "Id de Usuario";
            // 
            // DescripcionTxt
            // 
            DescripcionTxt.Location = new Point(364, 130);
            DescripcionTxt.Name = "DescripcionTxt";
            DescripcionTxt.Size = new Size(250, 26);
            DescripcionTxt.TabIndex = 6;
            DescripcionTxt.TextChanged += DescripcionTxt_TextChanged;
            // 
            // PrecioTxt
            // 
            PrecioTxt.Location = new Point(364, 177);
            PrecioTxt.Name = "PrecioTxt";
            PrecioTxt.Size = new Size(250, 26);
            PrecioTxt.TabIndex = 7;
            PrecioTxt.TextChanged += PrecioTxt_TextChanged;
            // 
            // CostoTxt
            // 
            CostoTxt.Location = new Point(364, 221);
            CostoTxt.Name = "CostoTxt";
            CostoTxt.Size = new Size(250, 26);
            CostoTxt.TabIndex = 8;
            CostoTxt.TextChanged += CostoTxt_TextChanged;
            // 
            // StockTxt
            // 
            StockTxt.Location = new Point(364, 268);
            StockTxt.Name = "StockTxt";
            StockTxt.Size = new Size(250, 26);
            StockTxt.TabIndex = 9;
            StockTxt.TextChanged += StockTxt_TextChanged;
            // 
            // UsuarioTxt
            // 
            UsuarioTxt.Location = new Point(364, 321);
            UsuarioTxt.Name = "UsuarioTxt";
            UsuarioTxt.Size = new Size(250, 26);
            UsuarioTxt.TabIndex = 10;
            UsuarioTxt.TextChanged += UsuarioTxt_TextChanged;
            // 
            // BotonCrear
            // 
            BotonCrear.Location = new Point(662, 394);
            BotonCrear.Name = "BotonCrear";
            BotonCrear.Size = new Size(110, 33);
            BotonCrear.TabIndex = 11;
            BotonCrear.Text = "Crear";
            BotonCrear.UseVisualStyleBackColor = true;
            BotonCrear.Click += BotonCrear_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(397, 350);
            label7.Name = "label7";
            label7.Size = new Size(192, 20);
            label7.TabIndex = 12;
            label7.Text = "El id de usuario debe existir";
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(BotonCrear);
            Controls.Add(UsuarioTxt);
            Controls.Add(StockTxt);
            Controls.Add(CostoTxt);
            Controls.Add(PrecioTxt);
            Controls.Add(DescripcionTxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarProducto";
            Text = "AgregarProducto";
            Load += AgregarProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox DescripcionTxt;
        private TextBox PrecioTxt;
        private TextBox CostoTxt;
        private TextBox StockTxt;
        private TextBox UsuarioTxt;
        private Button BotonCrear;
        private Label label7;
    }
}