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
            SuspendLayout();
            // 
            // IdDeUsuarioTxt
            // 
            IdDeUsuarioTxt.Location = new Point(369, 208);
            IdDeUsuarioTxt.Name = "IdDeUsuarioTxt";
            IdDeUsuarioTxt.Size = new Size(250, 26);
            IdDeUsuarioTxt.TabIndex = 29;
            // 
            // ComentariosTxt
            // 
            ComentariosTxt.Location = new Point(369, 156);
            ComentariosTxt.Name = "ComentariosTxt";
            ComentariosTxt.Size = new Size(250, 26);
            ComentariosTxt.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(197, 202);
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
            label2.Location = new Point(197, 149);
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
            label7.Location = new Point(403, 237);
            label7.Name = "label7";
            label7.Size = new Size(192, 20);
            label7.TabIndex = 34;
            label7.Text = "El id de usuario debe existir";
            // 
            // AgregarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(800, 450);
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
    }
}