namespace Clase11EntityFramework_Migrations_CodeFirst
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
            dbvLista = new DataGridView();
            btnCargarProductos = new Button();
            btnCargarUsuarios = new Button();
            ((System.ComponentModel.ISupportInitialize)dbvLista).BeginInit();
            SuspendLayout();
            // 
            // dbvLista
            // 
            dbvLista.AllowUserToAddRows = false;
            dbvLista.AllowUserToDeleteRows = false;
            dbvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbvLista.Location = new Point(12, 178);
            dbvLista.Name = "dbvLista";
            dbvLista.ReadOnly = true;
            dbvLista.RowTemplate.Height = 25;
            dbvLista.Size = new Size(776, 260);
            dbvLista.TabIndex = 0;
            // 
            // btnCargarProductos
            // 
            btnCargarProductos.Location = new Point(12, 128);
            btnCargarProductos.Name = "btnCargarProductos";
            btnCargarProductos.Size = new Size(138, 44);
            btnCargarProductos.TabIndex = 1;
            btnCargarProductos.Text = "Cargar Productos";
            btnCargarProductos.UseVisualStyleBackColor = true;
            btnCargarProductos.Click += btnCargarProductos_Click;
            // 
            // btnCargarUsuarios
            // 
            btnCargarUsuarios.Location = new Point(156, 128);
            btnCargarUsuarios.Name = "btnCargarUsuarios";
            btnCargarUsuarios.Size = new Size(138, 44);
            btnCargarUsuarios.TabIndex = 2;
            btnCargarUsuarios.Text = "Cargar Usuarios";
            btnCargarUsuarios.UseVisualStyleBackColor = true;
            btnCargarUsuarios.Click += btnCargarUsuarios_Click;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCargarUsuarios);
            Controls.Add(btnCargarProductos);
            Controls.Add(dbvLista);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dbvLista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dbvLista;
        private Button btnCargarProductos;
        private Button btnCargarUsuarios;
    }
}
