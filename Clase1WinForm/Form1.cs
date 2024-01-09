namespace Clase1WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //variables
            int radioCirculo = 3;
            double areaCirculo;
            const double pi = 3.14159;

            areaCirculo = pi * (radioCirculo * radioCirculo);

            lblAreaCirculo.Text = areaCirculo.ToString();
        }
    }
}
