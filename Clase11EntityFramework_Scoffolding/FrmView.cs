using Clase11EntityFramework_Scoffolding.Database;
using Clase11EntityFramework_Scoffolding.Models;
namespace Clase11EntityFramework_Scoffolding
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

        public void btnCargarUsuarios_Click(object sender, EventArgs e)
        {
            using (CoderContext database = new CoderContext())
            {
                List<Usuario> usuarios = database.Usuarios.ToList();
                this.dgvLista.DataSource = usuarios;
            }
            
        }

        public void btnCargarProductos_Click(object sender, EventArgs e)
        {
            using (CoderContext database = new CoderContext())
            {
                List<Producto> productos = database.Productos.ToList();
                this.dgvLista.DataSource = productos;
            }
        }
    }
}
