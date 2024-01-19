namespace Clase7ListasBasicosWinForm
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
            lblHolaMundo = new Label();
            lstRazasDePerros = new ListBox();
            lblRazasDePerros = new Label();
            lblProductoCaro = new Label();
            lstCiudadesPais = new ListBox();
            lblCiudadesPais = new Label();
            btnBuscar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // lblHolaMundo
            // 
            lblHolaMundo.AutoSize = true;
            lblHolaMundo.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblHolaMundo.Location = new Point(60, 45);
            lblHolaMundo.Name = "lblHolaMundo";
            lblHolaMundo.Size = new Size(205, 46);
            lblHolaMundo.TabIndex = 0;
            lblHolaMundo.Text = "Hola mundo";
            // 
            // lstRazasDePerros
            // 
            lstRazasDePerros.FormattingEnabled = true;
            lstRazasDePerros.ItemHeight = 15;
            lstRazasDePerros.Location = new Point(70, 200);
            lstRazasDePerros.Name = "lstRazasDePerros";
            lstRazasDePerros.Size = new Size(270, 124);
            lstRazasDePerros.TabIndex = 1;
            // 
            // lblRazasDePerros
            // 
            lblRazasDePerros.AutoSize = true;
            lblRazasDePerros.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblRazasDePerros.Location = new Point(70, 160);
            lblRazasDePerros.Name = "lblRazasDePerros";
            lblRazasDePerros.Size = new Size(201, 37);
            lblRazasDePerros.TabIndex = 2;
            lblRazasDePerros.Text = "Razas de Perros";
            // 
            // lblProductoCaro
            // 
            lblProductoCaro.AutoSize = true;
            lblProductoCaro.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductoCaro.Location = new Point(312, 396);
            lblProductoCaro.Name = "lblProductoCaro";
            lblProductoCaro.Size = new Size(194, 28);
            lblProductoCaro.TabIndex = 3;
            lblProductoCaro.Text = "Producto Más Caro : ";
            // 
            // lstCiudadesPais
            // 
            lstCiudadesPais.FormattingEnabled = true;
            lstCiudadesPais.ItemHeight = 15;
            lstCiudadesPais.Location = new Point(422, 200);
            lstCiudadesPais.Name = "lstCiudadesPais";
            lstCiudadesPais.Size = new Size(354, 124);
            lstCiudadesPais.TabIndex = 4;
            // 
            // lblCiudadesPais
            // 
            lblCiudadesPais.AutoSize = true;
            lblCiudadesPais.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblCiudadesPais.Location = new Point(468, 160);
            lblCiudadesPais.Name = "lblCiudadesPais";
            lblCiudadesPais.Size = new Size(226, 37);
            lblCiudadesPais.TabIndex = 5;
            lblCiudadesPais.Text = "Ciudades Por País";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(422, 107);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(84, 50);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(512, 107);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(84, 50);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar Item";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(602, 107);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(84, 50);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(692, 107);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(84, 50);
            btnLimpiar.TabIndex = 9;
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
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(lblCiudadesPais);
            Controls.Add(lstCiudadesPais);
            Controls.Add(lblProductoCaro);
            Controls.Add(lblRazasDePerros);
            Controls.Add(lstRazasDePerros);
            Controls.Add(lblHolaMundo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHolaMundo;
        private ListBox lstRazasDePerros;
        private Label lblRazasDePerros;
        private Label lblProductoCaro;
        private ListBox lstCiudadesPais;
        private Label lblCiudadesPais;
        private Button btnBuscar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnLimpiar;
    }
}
