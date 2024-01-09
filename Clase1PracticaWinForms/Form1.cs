namespace Clase1PracticaWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarMensaje_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "Bienvenido a Coderhouse " + txtNombre.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
