namespace Clase9ConsultaDatosADO_NET_actividadEnClaseForm2
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
            dgvUsuarios = new DataGridView();
            lblListaUsuarios = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 90);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(765, 348);
            dgvUsuarios.TabIndex = 0;
            // 
            // lblListaUsuarios
            // 
            lblListaUsuarios.AutoSize = true;
            lblListaUsuarios.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblListaUsuarios.Location = new Point(181, 41);
            lblListaUsuarios.Name = "lblListaUsuarios";
            lblListaUsuarios.Size = new Size(295, 46);
            lblListaUsuarios.TabIndex = 1;
            lblListaUsuarios.Text = "Lista de Usuarios : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblListaUsuarios);
            Controls.Add(dgvUsuarios);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Label lblListaUsuarios;
    }
}
