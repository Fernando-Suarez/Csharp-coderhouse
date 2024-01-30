namespace Clase8ListasYMatricesActividad1
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
            dgvMostrarLista = new DataGridView();
            lblProductosE = new Label();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMostrarLista).BeginInit();
            SuspendLayout();
            // 
            // dgvMostrarLista
            // 
            dgvMostrarLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostrarLista.Location = new Point(12, 86);
            dgvMostrarLista.Name = "dgvMostrarLista";
            dgvMostrarLista.RowTemplate.Height = 25;
            dgvMostrarLista.Size = new Size(768, 352);
            dgvMostrarLista.TabIndex = 0;
            dgvMostrarLista.CellContentClick += dgvMostrarLista_CellContentClick;
            // 
            // lblProductosE
            // 
            lblProductosE.AutoSize = true;
            lblProductosE.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductosE.Location = new Point(12, 47);
            lblProductosE.Name = "lblProductosE";
            lblProductosE.Size = new Size(181, 28);
            lblProductosE.TabIndex = 1;
            lblProductosE.Text = "Productos con E : ";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(551, 38);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(226, 44);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar Lista";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(lblProductosE);
            Controls.Add(dgvMostrarLista);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMostrarLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMostrarLista;
        private Label lblProductosE;
        private Button btnLimpiar;
    }
}
