namespace Clase9ConsultaDatosADO_NET_actividadEnClaseForm
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
            dgvLista = new DataGridView();
            btnCrear = new Button();
            lblListaProductos = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // dgvLista
            // 
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(12, 97);
            dgvLista.Name = "dgvLista";
            dgvLista.RowTemplate.Height = 25;
            dgvLista.Size = new Size(777, 347);
            dgvLista.TabIndex = 0;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(675, 48);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(114, 43);
            btnCrear.TabIndex = 1;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += button1_Click;
            // 
            // lblListaProductos
            // 
            lblListaProductos.AutoSize = true;
            lblListaProductos.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblListaProductos.Location = new Point(280, 48);
            lblListaProductos.Name = "lblListaProductos";
            lblListaProductos.Size = new Size(234, 37);
            lblListaProductos.TabIndex = 2;
            lblListaProductos.Text = "Lista de Productos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblListaProductos);
            Controls.Add(btnCrear);
            Controls.Add(dgvLista);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLista;
        private Button btnCrear;
        private Label lblListaProductos;
    }
}
