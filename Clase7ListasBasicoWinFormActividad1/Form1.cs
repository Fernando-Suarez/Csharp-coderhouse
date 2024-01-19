using Microsoft.VisualBasic.Logging;
using System.Drawing;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Clase7ListasBasicoWinFormActividad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Se desarrollará un catálogo de productos a un pet shop clasificando por sección a los tipos de productos para cierto animal.
            //Luego se los mostrará en forma encolumnada en pantalla.
            //Se usará un diccionario<nombre, precio> dentro de otro diccionario < sección, diccionario < nombre,precio >>
            //y un ListBox para mostrar los resultados.


            //Declaración de un diccionario dentro de otro(anidado)
            //Creamos una estructura más compleja que el ejemplo anterior anidando un diccionario dentro de otro.
            //Para traducirlo en palabras decimos que por cada sección del catálogo, tendremos un conjunto de producto - precio que estarán asociados a dicha sección.
            //A continuación se verá un poco mejor esta estructura

            Dictionary<String, Dictionary<string, double>> catalogoPetShop = new Dictionary<string, Dictionary<string, double>>();

            //Agregamos los conjuntos de clave-valor al diccionario anidado
            //En el primer parámetro del catálogo agregamos la sección que contiene varios productos y su precio.
            //Entonces para asociarlos a la sección, debemos instanciar un nuevo diccionario con la estructura declarada, en el paso previo, e ingresar una descripción del producto
            //y su precio como conjuntos clave-valor entre llaves y separados por coma.

            catalogoPetShop.Add("Alimento Para Gatos Adultos", new Dictionary<string, double> { { "Cat Chow", 900 }, { "Wiskas", 1200 }, { "Pedigres", 1800 } });
            catalogoPetShop.Add("Alimento Para Perros Cachoros", new Dictionary<string, double> { { "Dog Chow", 700 }, { "Proplan", 900 }, { "Pedigres", 1100 } });
            catalogoPetShop.Add("Alimento Para Gatos Cachoros", new Dictionary<string, double> { { "Cat Chow ", 600 }, { "Wiskas", 850 }, { "Pedigres", 1250 } });
            catalogoPetShop.Add("Alimento Para Perros Adultos", new Dictionary<string, double> { { "Dog Chow", 850 }, { "Proplan", 1350 }, { "Pedigres", 1450 } });


            //Recorremos un Diccionario anidado
            //Formateamos la salida por pantalla de los datos para que se muestran encolumnados y agrupados por sección.
            //El \t lo que hace es agregar una tabulación al texto que lo sucede.
            //Con estas tabulaciones creamos unas “columnas ” para separar la información como nos pide el enunciado del problema

            // Se usa un foreach dentro de otro para poder recorrer los diccionarios que se encuentran anidados.
            // El primer foreach se utiliza para obtener el primer par de clave valor(Clave: seccion valor: diccionario<producto, precio>)
            // y con el segundo foreach recorremos el diccionario anidado y obtenemos los productos y sus precios asociados a la sección. 

            lstAlimento.Items.Add("Seccion\t\t\t\t\tProducto\t\tPrecio");
            foreach (KeyValuePair<String, Dictionary<string, double>> seccion in catalogoPetShop)
            {
                lstAlimento.Items.Add(seccion.Key);
                foreach (KeyValuePair<string, double> precioValor in seccion.Value)
                {
                    lstAlimento.Items.Add($"\t\t\t\t\t{precioValor.Key}\t\t{precioValor.Value}");
                }
            }
        }

        private void lstAlimento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
