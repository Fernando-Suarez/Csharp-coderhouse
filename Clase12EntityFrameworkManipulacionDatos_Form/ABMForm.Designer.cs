namespace Clase12EntityFrameworkManipulacionDatos_Form
{
    partial class ABMForm
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
            btnABMAceptar = new Button();
            txtEmail = new TextBox();
            txtNombreUsuario = new TextBox();
            txtNombre = new TextBox();
            txtPassword = new TextBox();
            txtApellido = new TextBox();
            SuspendLayout();
            // 
            // btnABMAceptar
            // 
            btnABMAceptar.Location = new Point(268, 369);
            btnABMAceptar.Name = "btnABMAceptar";
            btnABMAceptar.Size = new Size(274, 23);
            btnABMAceptar.TabIndex = 0;
            btnABMAceptar.Text = "Aceptar";
            btnABMAceptar.UseVisualStyleBackColor = true;
            btnABMAceptar.Click += btnABMAceptar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(288, 317);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Ingrese Un Email";
            txtEmail.Size = new Size(224, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(288, 214);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.PlaceholderText = "Ingrese un Nombre de Usuario";
            txtNombreUsuario.Size = new Size(224, 23);
            txtNombreUsuario.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(288, 123);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese un Nombre";
            txtNombre.Size = new Size(224, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(288, 265);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Ingrese un Password";
            txtPassword.Size = new Size(224, 23);
            txtPassword.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(288, 169);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingrese un Apellido";
            txtApellido.Size = new Size(224, 23);
            txtApellido.TabIndex = 5;
            // 
            // ABMForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(txtApellido);
            Controls.Add(txtPassword);
            Controls.Add(txtNombre);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtEmail);
            Controls.Add(btnABMAceptar);
            Name = "ABMForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ABMForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnABMAceptar;
        private TextBox txtEmail;
        private TextBox txtNombreUsuario;
        private TextBox txtNombre;
        private TextBox txtPassword;
        private TextBox txtApellido;
    }
}