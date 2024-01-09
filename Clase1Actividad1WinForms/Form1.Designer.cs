namespace Clase1Actividad1WinForms
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblDNI = new Label();
            lblEdad = new Label();
            lblAltura = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            txtEdad = new TextBox();
            txtAltura = new TextBox();
            btnInformacion = new Button();
            btnSuma = new Button();
            btnAlias = new Button();
            lblDatosUsuario = new Label();
            label1 = new Label();
            label2 = new Label();
            lblSuma = new Label();
            lblAlias = new Label();
            lblNumero1 = new Label();
            lblNumero2 = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            lblAliasUsuario = new Label();
            txtAlias = new TextBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(90, 63);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre :";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(87, 93);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(60, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido : ";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(87, 122);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(36, 15);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI : ";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(87, 151);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad:";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(87, 180);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(45, 15);
            lblAltura.TabIndex = 4;
            lblAltura.Text = "Altura :";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(220, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(192, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(220, 93);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(192, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(220, 122);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(192, 23);
            txtDNI.TabIndex = 7;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(220, 151);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(192, 23);
            txtEdad.TabIndex = 8;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(220, 180);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(192, 23);
            txtAltura.TabIndex = 9;
            // 
            // btnInformacion
            // 
            btnInformacion.Location = new Point(220, 223);
            btnInformacion.Name = "btnInformacion";
            btnInformacion.Size = new Size(147, 39);
            btnInformacion.TabIndex = 10;
            btnInformacion.Text = "Informacion";
            btnInformacion.UseVisualStyleBackColor = true;
            btnInformacion.Click += btnInformacion_Click;
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(538, 223);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(147, 39);
            btnSuma.TabIndex = 11;
            btnSuma.Text = "Sumar";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnAlias
            // 
            btnAlias.Location = new Point(153, 367);
            btnAlias.Name = "btnAlias";
            btnAlias.Size = new Size(147, 39);
            btnAlias.TabIndex = 12;
            btnAlias.Text = "Alias";
            btnAlias.UseVisualStyleBackColor = true;
            btnAlias.Click += btnAlias_Click;
            // 
            // lblDatosUsuario
            // 
            lblDatosUsuario.AutoSize = true;
            lblDatosUsuario.Location = new Point(220, 288);
            lblDatosUsuario.Name = "lblDatosUsuario";
            lblDatosUsuario.Size = new Size(0, 15);
            lblDatosUsuario.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(400, 218);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(412, 223);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 15;
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(538, 288);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(0, 15);
            lblSuma.TabIndex = 16;
            // 
            // lblAlias
            // 
            lblAlias.AutoSize = true;
            lblAlias.Location = new Point(412, 404);
            lblAlias.Name = "lblAlias";
            lblAlias.Size = new Size(0, 15);
            lblAlias.TabIndex = 17;
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(508, 151);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(66, 15);
            lblNumero1.TabIndex = 18;
            lblNumero1.Text = "Numero 1 :";
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(508, 180);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(66, 15);
            lblNumero2.TabIndex = 19;
            lblNumero2.Text = "Numero 2 :";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(589, 143);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(192, 23);
            txtNumero1.TabIndex = 20;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(589, 180);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(192, 23);
            txtNumero2.TabIndex = 21;
            // 
            // lblAliasUsuario
            // 
            lblAliasUsuario.AutoSize = true;
            lblAliasUsuario.Location = new Point(87, 336);
            lblAliasUsuario.Name = "lblAliasUsuario";
            lblAliasUsuario.Size = new Size(38, 15);
            lblAliasUsuario.TabIndex = 22;
            lblAliasUsuario.Text = "Alias :";
            // 
            // txtAlias
            // 
            txtAlias.Location = new Point(153, 338);
            txtAlias.Name = "txtAlias";
            txtAlias.Size = new Size(192, 23);
            txtAlias.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAlias);
            Controls.Add(lblAliasUsuario);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblNumero2);
            Controls.Add(lblNumero1);
            Controls.Add(lblAlias);
            Controls.Add(lblSuma);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDatosUsuario);
            Controls.Add(btnAlias);
            Controls.Add(btnSuma);
            Controls.Add(btnInformacion);
            Controls.Add(txtAltura);
            Controls.Add(txtEdad);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblAltura);
            Controls.Add(lblEdad);
            Controls.Add(lblDNI);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblDNI;
        private Label lblEdad;
        private Label lblAltura;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private TextBox txtEdad;
        private TextBox txtAltura;
        private Button btnInformacion;
        private Button btnSuma;
        private Button btnAlias;
        private Label lblDatosUsuario;
        private Label label1;
        private Label label2;
        private Label lblSuma;
        private Label lblAlias;
        private Label lblNumero1;
        private Label lblNumero2;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Label lblAliasUsuario;
        private TextBox txtAlias;
    }
}
