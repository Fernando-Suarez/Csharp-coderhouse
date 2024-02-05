namespace Clase12EntityFrameworkManipulacionDatos_Form
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
            dgvDatos = new DataGridView();
            btnListar = new Button();
            btnBuscarId = new Button();
            txtBuscarId = new TextBox();
            btnCrear = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(154, 12);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(634, 426);
            dgvDatos.TabIndex = 0;
            dgvDatos.SelectionChanged += dgvDatos_SelectionChanged;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(10, 12);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(138, 49);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnBuscarId
            // 
            btnBuscarId.Location = new Point(10, 112);
            btnBuscarId.Name = "btnBuscarId";
            btnBuscarId.Size = new Size(138, 49);
            btnBuscarId.TabIndex = 2;
            btnBuscarId.Text = "Buscar por ID";
            btnBuscarId.UseVisualStyleBackColor = true;
            btnBuscarId.Click += btnBuscarId_Click;
            // 
            // txtBuscarId
            // 
            txtBuscarId.Location = new Point(10, 83);
            txtBuscarId.Name = "txtBuscarId";
            txtBuscarId.PlaceholderText = "Ingrese ID";
            txtBuscarId.Size = new Size(138, 23);
            txtBuscarId.TabIndex = 3;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(10, 177);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(138, 49);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(10, 246);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(138, 49);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(10, 319);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(138, 49);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCrear);
            Controls.Add(txtBuscarId);
            Controls.Add(btnBuscarId);
            Controls.Add(btnListar);
            Controls.Add(dgvDatos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDatos;
        private Button btnListar;
        private Button btnBuscarId;
        private TextBox txtBuscarId;
        private Button btnCrear;
        private Button btnEliminar;
        private Button btnModificar;
    }
}
