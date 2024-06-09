namespace Windows_Froms_Proyecto_c_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            GuardarUsuarioYContraseña = new Button();
            usuarioTextBox = new TextBox();
            contraseñaTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            verUsuarioYContraseña = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(256, 29);
            label1.Name = "label1";
            label1.Size = new Size(285, 62);
            label1.TabIndex = 0;
            label1.Text = "¡Bienvenido!";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(268, 106);
            label2.Name = "label2";
            label2.Size = new Size(264, 32);
            label2.TabIndex = 1;
            label2.Text = "Registrate para ingresar";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // GuardarUsuarioYContraseña
            // 
            GuardarUsuarioYContraseña.BackColor = SystemColors.ActiveBorder;
            GuardarUsuarioYContraseña.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            GuardarUsuarioYContraseña.ForeColor = SystemColors.ActiveCaptionText;
            GuardarUsuarioYContraseña.Location = new Point(671, 382);
            GuardarUsuarioYContraseña.Name = "GuardarUsuarioYContraseña";
            GuardarUsuarioYContraseña.Size = new Size(100, 45);
            GuardarUsuarioYContraseña.TabIndex = 2;
            GuardarUsuarioYContraseña.Text = "Aceptar";
            GuardarUsuarioYContraseña.UseVisualStyleBackColor = false;
            GuardarUsuarioYContraseña.Click += GuardarUsuarioYContraseña_Click;
            // 
            // usuarioTextBox
            // 
            usuarioTextBox.BackColor = SystemColors.ControlLightLight;
            usuarioTextBox.ForeColor = SystemColors.InactiveCaptionText;
            usuarioTextBox.Location = new Point(283, 209);
            usuarioTextBox.Name = "usuarioTextBox";
            usuarioTextBox.Size = new Size(234, 26);
            usuarioTextBox.TabIndex = 3;
            usuarioTextBox.TextChanged += usuarioTextBox_TextChanged;
            // 
            // contraseñaTextBox
            // 
            contraseñaTextBox.Location = new Point(283, 296);
            contraseñaTextBox.Name = "contraseñaTextBox";
            contraseñaTextBox.Size = new Size(234, 26);
            contraseñaTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(358, 272);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(370, 185);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 6;
            label4.Text = "Usuario";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(283, 349);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 7;
            label5.Text = "Tu usuario:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(283, 382);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 8;
            label6.Text = "Tu contraseña:";
            // 
            // verUsuarioYContraseña
            // 
            verUsuarioYContraseña.BackColor = SystemColors.ButtonFace;
            verUsuarioYContraseña.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            verUsuarioYContraseña.ForeColor = SystemColors.ActiveCaptionText;
            verUsuarioYContraseña.Location = new Point(199, 358);
            verUsuarioYContraseña.Name = "verUsuarioYContraseña";
            verUsuarioYContraseña.Size = new Size(60, 30);
            verUsuarioYContraseña.TabIndex = 9;
            verUsuarioYContraseña.Text = "Ver";
            verUsuarioYContraseña.UseVisualStyleBackColor = false;
            verUsuarioYContraseña.Click += verUsuarioYContraseña_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(verUsuarioYContraseña);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(contraseñaTextBox);
            Controls.Add(usuarioTextBox);
            Controls.Add(GuardarUsuarioYContraseña);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button GuardarUsuarioYContraseña;
        private TextBox usuarioTextBox;
        private TextBox contraseñaTextBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button verUsuarioYContraseña;
    }
}