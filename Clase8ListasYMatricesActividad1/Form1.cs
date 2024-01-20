using System.Linq.Expressions;

namespace Clase8ListasYMatricesActividad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductoConE productoConE;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Descripción de la actividad. 
            //Dado un array con productos(solo Código, Descripción) precargados(no más de 10), se debe insertar en una lista  los elementos que contengan E.
            //Mostrar por pantalla los productos de la lista

            productoConE = new ProductoConE();

            Producto[] productos = { new Producto(1,"Notebook Lenovo"),
                                     new Producto(2,"Mouse Genius"),
                                     new Producto(3,"Teclado Generico"),
                                     new Producto(4,"Monitor 20"),
                                     new Producto(4,"Monitor 25")
            };

            productoConE.InsertarEnLista(productos);
            dgvMostrarLista.AutoGenerateColumns = true;  // genera las columnas automaticamente
            dgvMostrarLista.DataSource = productoConE.MostrarLista();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvMostrarLista.DataSource = null;
            productoConE.MostrarLista();
        }
    }
}
