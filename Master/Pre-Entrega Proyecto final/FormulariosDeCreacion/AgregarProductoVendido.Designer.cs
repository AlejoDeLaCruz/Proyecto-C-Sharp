namespace Pre_Entrega_Proyecto_final.FormulariosDeCreacion
{
    partial class AgregarProductoVendido
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
            IdDeVentaTxt = new TextBox();
            StockTxt = new TextBox();
            idProductoTxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BotonCrear = new Button();
            label7 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // IdDeVentaTxt
            // 
            IdDeVentaTxt.Location = new Point(380, 255);
            IdDeVentaTxt.Name = "IdDeVentaTxt";
            IdDeVentaTxt.Size = new Size(250, 26);
            IdDeVentaTxt.TabIndex = 19;
            // 
            // StockTxt
            // 
            StockTxt.Location = new Point(380, 211);
            StockTxt.Name = "StockTxt";
            StockTxt.Size = new Size(250, 26);
            StockTxt.TabIndex = 18;
            // 
            // idProductoTxt
            // 
            idProductoTxt.Location = new Point(380, 165);
            idProductoTxt.Name = "idProductoTxt";
            idProductoTxt.Size = new Size(250, 26);
            idProductoTxt.TabIndex = 17;
            idProductoTxt.TextChanged += idProductoTxt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(203, 249);
            label4.Name = "label4";
            label4.Size = new Size(135, 32);
            label4.TabIndex = 14;
            label4.Text = "Id de Venta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(203, 205);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 13;
            label3.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(203, 159);
            label2.Name = "label2";
            label2.Size = new Size(171, 32);
            label2.TabIndex = 12;
            label2.Text = "Id de Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(194, 43);
            label1.Name = "label1";
            label1.Size = new Size(425, 42);
            label1.TabIndex = 11;
            label1.Text = "CREAR PRODUCTO EN VENTA";
            label1.Click += label1_Click;
            // 
            // BotonCrear
            // 
            BotonCrear.Location = new Point(657, 392);
            BotonCrear.Name = "BotonCrear";
            BotonCrear.Size = new Size(101, 34);
            BotonCrear.TabIndex = 22;
            BotonCrear.Text = "Crear";
            BotonCrear.UseVisualStyleBackColor = true;
            BotonCrear.Click += BotonCrear_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(412, 284);
            label7.Name = "label7";
            label7.Size = new Size(180, 20);
            label7.TabIndex = 23;
            label7.Text = "El id de venta debe existir";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(401, 142);
            label5.Name = "label5";
            label5.Size = new Size(205, 20);
            label5.TabIndex = 24;
            label5.Text = "El id de producto debe existir";
            // 
            // AgregarProductoVendido
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(BotonCrear);
            Controls.Add(IdDeVentaTxt);
            Controls.Add(StockTxt);
            Controls.Add(idProductoTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "AgregarProductoVendido";
            Text = "AgregarProductoVendido";
            Load += AgregarProductoVendido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox IdDeVentaTxt;
        private TextBox StockTxt;
        private TextBox idProductoTxt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BotonCrear;
        private Label label7;
        private Label label5;
    }
}