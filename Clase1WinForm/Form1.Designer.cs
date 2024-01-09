namespace Clase1WinForm
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
            lblMensajeResultado = new Label();
            lblAreaCirculo = new Label();
            SuspendLayout();
            // 
            // lblMensajeResultado
            // 
            lblMensajeResultado.AutoSize = true;
            lblMensajeResultado.Location = new Point(193, 191);
            lblMensajeResultado.Name = "lblMensajeResultado";
            lblMensajeResultado.Size = new Size(122, 15);
            lblMensajeResultado.TabIndex = 0;
            lblMensajeResultado.Text = "El area del circulo es : ";
            // 
            // lblAreaCirculo
            // 
            lblAreaCirculo.AutoSize = true;
            lblAreaCirculo.Location = new Point(339, 191);
            lblAreaCirculo.Name = "lblAreaCirculo";
            lblAreaCirculo.Size = new Size(59, 15);
            lblAreaCirculo.TabIndex = 1;
            lblAreaCirculo.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAreaCirculo);
            Controls.Add(lblMensajeResultado);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensajeResultado;
        private Label lblAreaCirculo;
    }
}
