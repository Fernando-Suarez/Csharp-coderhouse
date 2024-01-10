namespace Clase4zAfterReciboSueldoWinForm
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
            lblValorHora = new Label();
            lblNombre = new Label();
            lblAntiguedad = new Label();
            lblHorasTrabajadas = new Label();
            btnCalcularMostrar = new Button();
            txtNombre = new TextBox();
            numAntiguedad = new NumericUpDown();
            numHorasTrabajadas = new NumericUpDown();
            numValorHora = new NumericUpDown();
            gbResultados = new GroupBox();
            lblTotalNeto = new Label();
            lblTotalBruto = new Label();
            lblDescuentos = new Label();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)numAntiguedad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHorasTrabajadas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numValorHora).BeginInit();
            gbResultados.SuspendLayout();
            SuspendLayout();
            // 
            // lblValorHora
            // 
            lblValorHora.AutoSize = true;
            lblValorHora.Location = new Point(134, 114);
            lblValorHora.Name = "lblValorHora";
            lblValorHora.Size = new Size(65, 15);
            lblValorHora.TabIndex = 0;
            lblValorHora.Text = "Valor Hora:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(134, 79);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblAntiguedad
            // 
            lblAntiguedad.AutoSize = true;
            lblAntiguedad.Location = new Point(134, 155);
            lblAntiguedad.Name = "lblAntiguedad";
            lblAntiguedad.Size = new Size(72, 15);
            lblAntiguedad.TabIndex = 2;
            lblAntiguedad.Text = "Antiguedad:";
            // 
            // lblHorasTrabajadas
            // 
            lblHorasTrabajadas.AutoSize = true;
            lblHorasTrabajadas.Location = new Point(134, 191);
            lblHorasTrabajadas.Name = "lblHorasTrabajadas";
            lblHorasTrabajadas.Size = new Size(99, 15);
            lblHorasTrabajadas.TabIndex = 3;
            lblHorasTrabajadas.Text = "Horas Trabajadas:";
            // 
            // btnCalcularMostrar
            // 
            btnCalcularMostrar.Location = new Point(248, 253);
            btnCalcularMostrar.Name = "btnCalcularMostrar";
            btnCalcularMostrar.Size = new Size(260, 72);
            btnCalcularMostrar.TabIndex = 4;
            btnCalcularMostrar.Text = "Calcular Importe a Cobrar";
            btnCalcularMostrar.UseVisualStyleBackColor = true;
            btnCalcularMostrar.Click += btnCalcularMostrar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(284, 71);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(224, 23);
            txtNombre.TabIndex = 6;
            // 
            // numAntiguedad
            // 
            numAntiguedad.Location = new Point(284, 147);
            numAntiguedad.Name = "numAntiguedad";
            numAntiguedad.Size = new Size(224, 23);
            numAntiguedad.TabIndex = 7;
            // 
            // numHorasTrabajadas
            // 
            numHorasTrabajadas.Location = new Point(284, 183);
            numHorasTrabajadas.Name = "numHorasTrabajadas";
            numHorasTrabajadas.Size = new Size(224, 23);
            numHorasTrabajadas.TabIndex = 8;
            // 
            // numValorHora
            // 
            numValorHora.Location = new Point(284, 106);
            numValorHora.Name = "numValorHora";
            numValorHora.Size = new Size(224, 23);
            numValorHora.TabIndex = 9;
            // 
            // gbResultados
            // 
            gbResultados.Controls.Add(lblTotalNeto);
            gbResultados.Controls.Add(lblTotalBruto);
            gbResultados.Controls.Add(lblDescuentos);
            gbResultados.Controls.Add(btnCerrar);
            gbResultados.Location = new Point(662, 71);
            gbResultados.Name = "gbResultados";
            gbResultados.Size = new Size(558, 254);
            gbResultados.TabIndex = 10;
            gbResultados.TabStop = false;
            gbResultados.Text = "Resultados:";
            gbResultados.Visible = false;
            // 
            // lblTotalNeto
            // 
            lblTotalNeto.AutoSize = true;
            lblTotalNeto.Location = new Point(33, 117);
            lblTotalNeto.Name = "lblTotalNeto";
            lblTotalNeto.Size = new Size(112, 15);
            lblTotalNeto.TabIndex = 8;
            lblTotalNeto.Text = "Total a Cobrar Neto:";
            // 
            // lblTotalBruto
            // 
            lblTotalBruto.AutoSize = true;
            lblTotalBruto.Location = new Point(33, 41);
            lblTotalBruto.Name = "lblTotalBruto";
            lblTotalBruto.Size = new Size(115, 15);
            lblTotalBruto.TabIndex = 7;
            lblTotalBruto.Text = "Total a Cobrar Bruto:";
            // 
            // lblDescuentos
            // 
            lblDescuentos.AutoSize = true;
            lblDescuentos.Location = new Point(33, 76);
            lblDescuentos.Name = "lblDescuentos";
            lblDescuentos.Size = new Size(71, 15);
            lblDescuentos.TabIndex = 6;
            lblDescuentos.Text = "Descuentos:";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(221, 182);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(142, 66);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 450);
            Controls.Add(gbResultados);
            Controls.Add(numValorHora);
            Controls.Add(numHorasTrabajadas);
            Controls.Add(numAntiguedad);
            Controls.Add(txtNombre);
            Controls.Add(btnCalcularMostrar);
            Controls.Add(lblHorasTrabajadas);
            Controls.Add(lblAntiguedad);
            Controls.Add(lblNombre);
            Controls.Add(lblValorHora);
            Name = "Form1";
            Text = "v";
            ((System.ComponentModel.ISupportInitialize)numAntiguedad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHorasTrabajadas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numValorHora).EndInit();
            gbResultados.ResumeLayout(false);
            gbResultados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValorHora;
        private Label lblNombre;
        private Label lblAntiguedad;
        private Label lblHorasTrabajadas;
        private Button btnCalcularMostrar;
        private TextBox txtNombre;
        private NumericUpDown numAntiguedad;
        private NumericUpDown numHorasTrabajadas;
        private NumericUpDown numValorHora;
        private GroupBox gbResultados;
        private Button btnCerrar;
        private Label lblTotalNeto;
        private Label lblTotalBruto;
        private Label lblDescuentos;
    }
}
