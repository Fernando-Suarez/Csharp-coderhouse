using Clase12EntityFrameworkManipulacionDatos_Form.database;
using Clase12EntityFrameworkManipulacionDatos_Form.models;
using Clase12EntityFrameworkManipulacionDatos_Form.service;

namespace Clase12EntityFrameworkManipulacionDatos_Form
{
    public partial class Form1 : Form
    {
        Usuario usuarioSeleccionado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = UsuarioService.ObtenerUsuarios();

        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            string stringId = txtBuscarId.Text;

            if (!string.IsNullOrWhiteSpace(stringId))
            {
                int id = Convert.ToInt32(stringId);
                dgvDatos.DataSource = UsuarioService.ObtenerUsuario(id);
            }
            else
            {
                MessageBox.Show("Completa el Id", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtBuscarId.Focus();
            }

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            ABMForm alta = new ABMForm();

            alta.ShowDialog();

            this.Hide();

            Usuario usuario = alta.UsuarioCreado;

            this.Show();
            if (UsuarioService.CrearUsuario(usuario))
            {
                MessageBox.Show("Agregue un usuario", "alta");
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string stringId = txtBuscarId.Text;

            if (!string.IsNullOrWhiteSpace(stringId))
            {
                int id = Convert.ToInt32(stringId);
                dgvDatos.DataSource = UsuarioService.EliminarUsuario(id);
                MessageBox.Show("Usuario Eliminado", "baja");
            }
            else
            {
                MessageBox.Show("Completa el Id", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtBuscarId.Focus();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ABMForm frm = new ABMForm(this.usuarioSeleccionado);
            frm.ShowDialog();

            Usuario usuarioModificado = frm.UsuarioCreado;

            if(UsuarioService.ModificarUsuario(usuarioModificado,this.usuarioSeleccionado.Id))
            {
                MessageBox.Show("Usuario Modificado", "Atencion",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

            
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            var seleccion = this.dgvDatos.SelectedRows;
            if(seleccion.Count > 0)
            {
                object dato = seleccion[0].DataBoundItem;
                this.usuarioSeleccionado = dato as Usuario;
            }
        }
    }
}
