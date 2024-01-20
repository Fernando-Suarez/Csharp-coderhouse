namespace Clase8ListasYMatricesAvanzado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Cargamos el DataGridView, Nótese el uso de la propiedad AutoGenerateColumns que hace que se generen las columnas del objeto asociado y la propiedad DataSourse para indicarle el origen de los datos a cargar
        ListaMayores mayores;
        private void CargarMayores()
        {
            dgvMayores.DataSource = null;
            dgvMayores.AutoGenerateColumns = true;
            dgvMayores.DataSource = mayores.GetListaClientes();
        }

        //En el Evento Load del Formulario Pre Cargamos un array con Cliente(Nombre, ID, Dirección, Edad) precargado, en el Evento Load del Formulario.
        private void Form1_Load(object sender, EventArgs e)
        {
            //Declaracion de una lista
            //List<string> nombres = new List<string> { "Roman", "Ana", "Felipe" };

            //Recorrer una lista 

            //foreach (string nombre in nombres)
            //{
            //    lstListaNombres.Items.Add(nombre.ToUpper());
            //}

            mayores = new ListaMayores();

            Cliente[] clientes = { new Cliente( "Juan Perez", 12354, "Larrea 432", 52),
                                   new Cliente("Elisabeth Aguirre", 25426, "La Rioja 852", 35),
                                   new Cliente("Rodrigo Ruiz", 87165,"Larrea 435", 85),
                                   new Cliente("Laura Gonzalez",78965,"Av La Plata 1535",45),
                                   new Cliente("Rene Mendez",46289,"San Bautista 789", 25),
                                   new Cliente("Elena Gonzales",65852,"Larrea 487", 49) };

            mayores.InsertarEnLista(clientes);
            CargarMayores();

            // Metodos de las List
            //Add - Agrega un elemento a la lista
            //Remove - Quita la primera aparicion de un objeto especificado 
            //Clear - Quita todos los elementos
            //Insert - Inserta un elemento en la lista en la posicion del indice especificado
            //Contains - Determina si un elemento se encuentra en la lista
            //Sort - Ordena los elementos de toda la lista utilizando un comparador
            //ToArray - Copia los elementos de una lista en un nuevo array
            //IndexOf - Devuelve el índice (de base cero) de la primera aparición de un valor en la lista o en una parte.

            //Propiedades de las List
            //Count - Obtine la cantidad de elementos de la lista
            //Capacity - La capacidad es el número de elementos que la lista puede almacenar antes de que sea necesario cambiar el tamaño de la lista (hace una reserva de memoria). Pero Count muestra lo que realmente contiene la lista.

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //En el Evento Click del botón Modificar realizamos la modificacion de un cliente y recargamos el DataGridView con la Lista Actualizada.

            Cliente aModificar = new Cliente("Laura Gonzalez", 78965, "Av La Plata 1535", 45);
            Cliente clienteNuevo = new Cliente("Laura Fernandez", 54752, "Rodriguez Peña 1845", 71);

            mayores.Modificar(aModificar, clienteNuevo);
            CargarMayores();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //En el Evento Click del botón borrar realizamos eliminamos un cliente y recargamos el DataGridView con la Lista Actualizada.

            Cliente clienteNuevo = new Cliente("Juan Perez", 12354, "Larrea 432", 52);

            //Para poder eliminar un dato de la lista se deve desvincular el origen del dato
            //dgvMayores.DataSource = null;

            mayores.Borrar(clienteNuevo);

            CargarMayores();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {

            mayores.Ordenar();
            CargarMayores();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            mayores.LimpiarLista();
            CargarMayores();
        }
    }
}
