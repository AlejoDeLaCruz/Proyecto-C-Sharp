namespace Pre_Entrega_Proyecto_final
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
            button1 = new Button();
            label1 = new Label();
            nombrePersona = new TextBox();
            apellidoPersona = new TextBox();
            nombreUsuarioPersona = new TextBox();
            emailPersona = new TextBox();
            contraseniaPersona = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(312, 379);
            button1.Name = "button1";
            button1.Size = new Size(187, 40);
            button1.TabIndex = 0;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(127, 154);
            label1.Name = "label1";
            label1.Size = new Size(73, 23);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            nombrePersona.Location = new Point(300, 154);
            nombrePersona.Name = "textBox1";
            nombrePersona.Size = new Size(114, 26);
            nombrePersona.TabIndex = 2;
            nombrePersona.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            apellidoPersona.Location = new Point(300, 257);
            apellidoPersona.Name = "textBox2";
            apellidoPersona.Size = new Size(114, 26);
            apellidoPersona.TabIndex = 3;
            // 
            // textBox3
            // 
            nombreUsuarioPersona.Location = new Point(300, 207);
            nombreUsuarioPersona.Name = "textBox3";
            nombreUsuarioPersona.Size = new Size(114, 26);
            nombreUsuarioPersona.TabIndex = 4;
            // 
            // textBox4
            // 
            emailPersona.Location = new Point(579, 207);
            emailPersona.Name = "textBox4";
            emailPersona.Size = new Size(114, 26);
            emailPersona.TabIndex = 5;
            // 
            // textBox5
            // 
            contraseniaPersona.Location = new Point(579, 154);
            contraseniaPersona.Name = "textBox5";
            contraseniaPersona.Size = new Size(114, 26);
            contraseniaPersona.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(268, 45);
            label2.Name = "label2";
            label2.Size = new Size(272, 42);
            label2.TabIndex = 1;
            label2.Text = "CREA TU USUARIO";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Cornsilk;
            label3.Location = new Point(127, 257);
            label3.Name = "label3";
            label3.Size = new Size(160, 23);
            label3.TabIndex = 7;
            label3.Text = "Nombre de Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Cornsilk;
            label4.Location = new Point(127, 207);
            label4.Name = "label4";
            label4.Size = new Size(72, 23);
            label4.TabIndex = 8;
            label4.Text = "Apellido";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Cornsilk;
            label5.Location = new Point(460, 154);
            label5.Name = "label5";
            label5.Size = new Size(51, 23);
            label5.TabIndex = 9;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Cornsilk;
            label6.Location = new Point(460, 207);
            label6.Name = "label6";
            label6.Size = new Size(97, 23);
            label6.TabIndex = 10;
            label6.Text = "Contraseña";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(contraseniaPersona);
            Controls.Add(emailPersona);
            Controls.Add(nombreUsuarioPersona);
            Controls.Add(apellidoPersona);
            Controls.Add(nombrePersona);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox nombrePersona;
        private TextBox apellidoPersona;
        private TextBox nombreUsuarioPersona;
        private TextBox emailPersona;
        private TextBox contraseniaPersona;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}