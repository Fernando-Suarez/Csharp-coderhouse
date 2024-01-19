
using System;

namespace Clase7ListasBasicosWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Declaracion de un dictionario
        Dictionary<String, String> ciudadesxPaises = new Dictionary<String, String>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Declarar un array
            string[] razaDePerros = new string[5];

            //Inicializar el array 
            razaDePerros[0] = "Dalmata";
            razaDePerros[1] = "Ovejero Aleman";
            razaDePerros[2] = "Salchicha";
            razaDePerros[3] = "Caniche";
            razaDePerros[4] = "Pequines";

            //Agregamos a la lista los elemento del array

            for (int i = 0; i < razaDePerros.Length; i++)
            {
                lstRazasDePerros.Items.Add(razaDePerros[i]);
            }


            // Array de objetos 

            Producto[] bebidasGaseosas =
               {
            new Producto(1,"Coca Cola",1500, 2000, "Gaseosa" ),
            new Producto(2,"Manaos",1000, 1400, "Gaseosa" ),
            new Producto(3,"Fanta",1400, 1900, "Gaseosa" ),
            new Producto(4,"Sprite",1450, 1950, "Gaseosa" )
        };

            //Vemos que para recorrer el array de objetos llamado bebidasGaseosas utilizamos un foreach que, por cada iteración, “copia” el elemento actual leído en la variable bebida.
            //Esta variable podemos usarla y, en este caso, realizar una comparación para obtener el producto más caro según el precio de compra.
            Producto bebidaMasCara = new Producto();

            //Utilizamos un foreach para recorrer el array de Objetos

            foreach (Producto bebida in bebidasGaseosas)
            {
                if (bebida.PrecioCompra > bebidaMasCara.PrecioCompra)
                {
                    bebidaMasCara = bebida;
                }
            }
            lblProductoCaro.Text += bebidaMasCara.Descripcion;


            //Diccionarios 
            //Un diccionario es una colección no ordenada de objetos.
            //Es por eso que para identificar un valor cualquiera dentro de él, especificamos una clave(a diferencia de los arrays cuyos elementos se identifican por su posición).
            //Es decir, las claves deben ser únicas.


            //Metodos y propiedades
            //Los diccionarios, al igual que los arrays, son objetos propios del lenguaje.
            //Este diseño permite que estas estructuras hereden e implementen propiedades y métodos propios de cada uno.
            //Veremos, a continuación, los métodos y propiedades de los diccionarios.

            //Propiedades:
            //Count : Obtiene la cantidad de pares clave-valor incluidos en un diccionario
            //Item[] : Obtiene o establece el valor asociado a la clave especificada. (Es como el getters and setters de un diccionario)
            //Keys : Obtiene una colección que contiene las claves de un diccionario
            //Values : Obtiene una colleción que contiene los valores de un diccionario.

            //Metodos:
            //Add : Agrega un objeto al final de la lista
            //Remove : Quita el valor con la clave especificada del diccionario
            //Clear : Quita todas las claves y valores de un diccionario
            //ContainsKeys : Determina si un diccionario contiene la clave especificada.
            //ContainsValues : Determina si un diccionario contiene el valor especificado.
            //TryGetValue : Obtiene el valor asociado a la clave especificada.


            //Agregamos elementos clave valor

            ciudadesxPaises.Add("Bucaramanga", "Chile");
            ciudadesxPaises.Add("Bogota", "Colombia");
            ciudadesxPaises.Add("Sucre", "Bolivia");
            ciudadesxPaises.Add("Lima", "Bolivia");
            ciudadesxPaises.Add("Buenos Aires", "Argentina");
            ciudadesxPaises.Add("Mexico DF", "Mexico");
            ciudadesxPaises.Add("Asunción", "Paraguay");

            //Recorremos Diccionario
            //Utilizamos un objeto Clave-valor (KeyValuePair) para obtener un elemento del diccionario y poder realizar el recorrido a través del foreach.

            foreach (KeyValuePair<String, String> ciudad in ciudadesxPaises)
            {
                lstCiudadesPais.Items.Add($"{ciudad.Key} - {ciudad.Value}");
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ciudadesxPaises.Remove("Bucaramanga");

            //Limpiamos el listBox
            lstCiudadesPais.Items.Clear();

            //Mostramos el Formulario con sus modificaciones
            foreach (KeyValuePair<String, String> ciudad in ciudadesxPaises)
            {
                lstCiudadesPais.Items.Add($"{ciudad.Key} - {ciudad.Value}");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Modificamos la key lima con el value peru
            ciudadesxPaises["Lima"] = "Peru";

            //Limpiamos el listBox
            lstCiudadesPais.Items.Clear();

            //Mostramos el Formulario con sus modificaciones
            foreach (KeyValuePair<String, String> ciudad in ciudadesxPaises)
            {
                lstCiudadesPais.Items.Add($"{ciudad.Key} - {ciudad.Value}");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Mediante ContainsKey validamos que exista la clave “Lima”.
            //Si es así, obtengo el valor del país asociado.
            //Luego , la muestro por pantalla, obsérvese el uso de la clase MessageBox y su método Show que nos permite mostrar un mensaje al usuario.
            //En el evento del botón Buscar.

            string pais;
            if (ciudadesxPaises.ContainsKey("Lima"))
            {
                ciudadesxPaises.TryGetValue("Lima", out pais);

                //mostramos un mensaje al usuario
                MessageBox.Show($"El pais donde pertene la ciudad de Lima es {pais}");
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ciudadesxPaises.Clear();
            lstCiudadesPais.Items.Clear();
            MessageBox.Show("Se limpio el contenido del diccionario");
        }
    }
}
