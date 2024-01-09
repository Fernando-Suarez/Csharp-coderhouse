namespace Clase2LoginWinForm
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
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            lblPass = new Label();
            btnLogin = new Button();
            lblPerfil = new Label();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(297, 121);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(297, 139);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(163, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(297, 210);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(163, 23);
            txtPass.TabIndex = 3;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(297, 192);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(57, 15);
            lblPass.TabIndex = 2;
            lblPass.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(316, 269);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(108, 40);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Location = new Point(293, 370);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(0, 15);
            lblPerfil.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPerfil);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(lblPass);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private Label lblPass;
        private Button btnLogin;
        private Label lblPerfil;
    }
}
