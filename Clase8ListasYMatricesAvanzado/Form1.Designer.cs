namespace Clase8ListasYMatricesAvanzado
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
            dgvMayores = new DataGridView();
            btnModificar = new Button();
            btnBorrar = new Button();
            btnOrdenar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMayores).BeginInit();
            SuspendLayout();
            // 
            // dgvMayores
            // 
            dgvMayores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMayores.Location = new Point(12, 103);
            dgvMayores.Name = "dgvMayores";
            dgvMayores.RowTemplate.Height = 25;
            dgvMayores.Size = new Size(776, 335);
            dgvMayores.TabIndex = 0;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(12, 30);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(136, 67);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(217, 30);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(136, 67);
            btnBorrar.TabIndex = 2;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(430, 30);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(136, 67);
            btnOrdenar.TabIndex = 3;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(652, 30);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(136, 67);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOrdenar);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(dgvMayores);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMayores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMayores;
        private Button btnModificar;
        private Button btnBorrar;
        private Button btnOrdenar;
        private Button btnLimpiar;
    }
}
