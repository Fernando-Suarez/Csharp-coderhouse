using Clase11EntityFramework_Migrations_CodeFirst.database;
using Clase11EntityFramework_Migrations_CodeFirst.models;

namespace Clase11EntityFramework_Migrations_CodeFirst
{
    public partial class FrmView : Form
    {
        public FrmView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarProductos_Click(object sender, EventArgs e)
        {
            using (DatabaseContext context = new DatabaseContext()) 
            {
                List<Producto> productos = context.Productos.ToList();
                this.dbvLista.DataSource = productos;
            } 

        }

        private void btnCargarUsuarios_Click(object sender, EventArgs e)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                List<Usuario> usuarios = context.Usuarios.ToList();
                this.dbvLista.DataSource = usuarios;
            }

        }
    }
}
