using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clase7ListasBasicoWinFormActividad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Descripción de la actividad. 
            //Mediante diccionarios crear un menú de un restaurante(elección libre según el tipo de comida).
            //Tener en cuenta que se debe imprimir platos y precio agrupados por el tipo de plato(bebidas alcohólicas, bebidas sin alcohol, entradas, plato principal, postre).  
            //Los nombres de los platos deben mostrarse en mayúsculas.

            Dictionary<string, Dictionary<string, double>> casaDeComidas = new Dictionary<string, Dictionary<string, double>> ();

            //Seccion,Bebidas, Entradas,Plato Principal

            casaDeComidas.Add("Bebidas", new Dictionary<string,double> { {"Coca Cola", 100 },{"Fanta", 100 },{"Sprite",100 } } );
            casaDeComidas.Add("Entradas" , new Dictionary<string,double> { {"Vitel Tone", 800}, {"Rabas",1000 }, {"Fiambre",200 } });
            casaDeComidas.Add("Plato Principal", new Dictionary<string, double> { {"Lomo",1000 },{"Milanesa",500 },{"Pasta", 800 } });

            //Producto Precio

            lstCasaDeComidas.Items.Add("Seccion\t\t\t\t\tProducto\t\tPrecio");

            foreach (KeyValuePair<string, Dictionary<string,double>> seccion in casaDeComidas)
            {
                lstCasaDeComidas.Items.Add(seccion.Key);
                foreach (KeyValuePair<string,double> precioValor in seccion.Value)
                {
                    lstCasaDeComidas.Items.Add($"\t\t\t\t\t{precioValor.Key}\t\t{precioValor.Value}");
                }
            }



        }
    }
}
