namespace Clase11EntityFramework_Scoffolding
{
    partial class FrmView
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
            dgvLista = new DataGridView();
            btnCargarProductos = new Button();
            btnCargarUsuarios = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // dgvLista
            // 
            dgvLista.AllowUserToAddRows = false;
            dgvLista.AllowUserToDeleteRows = false;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(12, 174);
            dgvLista.Name = "dgvLista";
            dgvLista.ReadOnly = true;
            dgvLista.RowTemplate.Height = 25;
            dgvLista.Size = new Size(776, 264);
            dgvLista.TabIndex = 0;
            // 
            // btnCargarProductos
            // 
            btnCargarProductos.Location = new Point(12, 110);
            btnCargarProductos.Name = "btnCargarProductos";
            btnCargarProductos.Size = new Size(143, 58);
            btnCargarProductos.TabIndex = 1;
            btnCargarProductos.Text = "Cargar Productos";
            btnCargarProductos.UseVisualStyleBackColor = true;
            btnCargarProductos.Click += this.btnCargarProductos_Click;
            // 
            // btnCargarUsuarios
            // 
            btnCargarUsuarios.Location = new Point(161, 110);
            btnCargarUsuarios.Name = "btnCargarUsuarios";
            btnCargarUsuarios.Size = new Size(140, 58);
            btnCargarUsuarios.TabIndex = 2;
            btnCargarUsuarios.Text = "Cargar Usuarios";
            btnCargarUsuarios.UseVisualStyleBackColor = true;
            btnCargarUsuarios.Click += this.btnCargarUsuarios_Click;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCargarUsuarios);
            Controls.Add(btnCargarProductos);
            Controls.Add(dgvLista);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLista;
        private Button btnCargarProductos;
        private Button btnCargarUsuarios;
    }
}
