namespace Clase1Actividad1WinForms
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {

            lblDatosUsuario.Text = $"{txtNombre.Text} {txtApellido.Text} {txtDNI.Text} {txtEdad.Text} {txtAltura.Text}";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultadoSuma = 0;

            numero1 = Convert.ToDouble(txtNumero1.Text);

            numero2 = Convert.ToDouble(txtNumero2.Text);

            resultadoSuma = numero1 + numero2;

            lblSuma.Text = resultadoSuma.ToString();
        }

        private void btnAlias_Click(object sender, EventArgs e)
        {
            string alias = $" \"{txtAlias.Text}\" ";

            lblAlias.Text = $"Mi nombre es : {txtNombre.Text} {alias} {txtApellido.Text} ";
        }
    }
}
