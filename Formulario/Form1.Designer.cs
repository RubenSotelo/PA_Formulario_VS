namespace Formulario
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
            tbNombre = new TextBox();
            tbApellido = new TextBox();
            label2 = new Label();
            tbTelefono = new TextBox();
            label3 = new Label();
            tbEdad = new TextBox();
            label4 = new Label();
            tbEstatura = new TextBox();
            label5 = new Label();
            rbHombre = new RadioButton();
            rbMujer = new RadioButton();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 15);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(147, 33);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(131, 23);
            tbNombre.TabIndex = 1;
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(147, 87);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(131, 23);
            tbApellido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 69);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(147, 139);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(131, 23);
            tbTelefono.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 121);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Telefono";
            // 
            // tbEdad
            // 
            tbEdad.Location = new Point(147, 194);
            tbEdad.Name = "tbEdad";
            tbEdad.Size = new Size(131, 23);
            tbEdad.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(194, 176);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 6;
            label4.Text = "Edad";
            // 
            // tbEstatura
            // 
            tbEstatura.Location = new Point(147, 251);
            tbEstatura.Name = "tbEstatura";
            tbEstatura.Size = new Size(131, 23);
            tbEstatura.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(184, 233);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 8;
            label5.Text = "Estatura";
            // 
            // rbHombre
            // 
            rbHombre.AutoSize = true;
            rbHombre.Location = new Point(147, 292);
            rbHombre.Name = "rbHombre";
            rbHombre.Size = new Size(69, 19);
            rbHombre.TabIndex = 10;
            rbHombre.TabStop = true;
            rbHombre.Text = "Hombre";
            rbHombre.UseVisualStyleBackColor = true;
            // 
            // rbMujer
            // 
            rbMujer.AutoSize = true;
            rbMujer.Location = new Point(222, 292);
            rbMujer.Name = "rbMujer";
            rbMujer.Size = new Size(56, 19);
            rbMujer.TabIndex = 11;
            rbMujer.TabStop = true;
            rbMujer.Text = "Mujer";
            rbMujer.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(129, 330);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += GuardarElemento;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(222, 330);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += LimpiarElemento;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(445, 389);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(rbMujer);
            Controls.Add(rbHombre);
            Controls.Add(tbEstatura);
            Controls.Add(label5);
            Controls.Add(tbEdad);
            Controls.Add(label4);
            Controls.Add(tbTelefono);
            Controls.Add(label3);
            Controls.Add(tbApellido);
            Controls.Add(label2);
            Controls.Add(tbNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNombre;
        private TextBox tbApellido;
        private Label label2;
        private TextBox tbTelefono;
        private Label label3;
        private TextBox tbEdad;
        private Label label4;
        private TextBox tbEstatura;
        private Label label5;
        private RadioButton rbHombre;
        private RadioButton rbMujer;
        private Button btnGuardar;
        private Button btnLimpiar;
    }
}
