namespace Clase4zAfterReciboSueldoWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            LimpiarResultados();
            gbResultados.Visible = false;
            
        }
        void LimpiarResultados()
        {
            this.lblDescuentos.Text = "Total Descuentos: ";

            this.lblTotalBruto.Text = "Total a cobrar bruto: ";

            this.lblTotalNeto.Text = "Total a cobrar neto: ";
        }

        private void btnCalcularMostrar_Click(object sender, EventArgs e)
        {
            //11.	Por teclado se ingresa el valor hora de un empleado.Posteriormente se ingresa el nombre del empleado, la antiguedad y la cantidad de horas trabajadas en el mes.
            //Se pide calcular el importe a cobrar teniendo en cuenta que al total que resuelta de multiplicar el valor hora por la cantidad de horas trabajadas,
            //hay que sumarle la cantidad de años trabajados multiplicados por $30, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.
            //Imprimir el recibo correspondiente con el nombre, la antiguedad, el valor hora, el total a cobrar en bruto, el total de descuentos y el valor neto a cobrar.

            decimal importeBruto = TotalBruto();
            decimal descuentos = TotalDescuentos(importeBruto);
            decimal importeNeto = TotalNeto(importeBruto,descuentos);

            LimpiarResultados();
            Resultados(importeBruto,descuentos,importeNeto);
            
        }
        void Resultados(decimal importeBruto,decimal descuentos, decimal importeNeto)
        {
            
            this.lblTotalBruto.Text += importeBruto.ToString();
            this.lblDescuentos.Text += descuentos.ToString();
            this.lblTotalNeto.Text += importeNeto.ToString();


            gbResultados.Visible = true;
        }
        decimal TotalBruto()
        {
            decimal antiguedad = Antiguedad();
            decimal importeACobrar = ImporteCobrar();

            return antiguedad + importeACobrar;
        }

        decimal Antiguedad()
        {
            return numAntiguedad.Value * 30;
        }

        decimal ImporteCobrar() 
        {
            return numValorHora.Value * numHorasTrabajadas.Value;
        }

        decimal TotalDescuentos(decimal totalBruto)
        {

            return totalBruto * 0.13m;
        }

        decimal TotalNeto(decimal totalBruto, decimal descuentos)
        {
            
            return totalBruto - descuentos;
        }
    }
}
