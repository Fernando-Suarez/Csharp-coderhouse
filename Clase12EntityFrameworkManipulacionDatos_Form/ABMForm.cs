using Clase12EntityFrameworkManipulacionDatos_Form.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase12EntityFrameworkManipulacionDatos_Form
{
    public partial class ABMForm : Form
    {
        public ABMForm()
        {
            InitializeComponent();
        }

        public ABMForm(Usuario usuario):this() 
        {
            this.txtNombre.Text = usuario.Nombre;
            this.txtApellido.Text = usuario.Apellido;
            this.txtNombreUsuario.Text = usuario.NombreUsuario;
            this.txtPassword.Text = usuario.Contraseña;
            this.txtEmail.Text = usuario.Mail;

        }
        public Usuario UsuarioCreado { get; private set; }
        private void btnABMAceptar_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario() {Nombre = this.txtNombre.Text, Apellido = this.txtApellido.Text,NombreUsuario =  this.txtNombreUsuario.Text, Contraseña = this.txtPassword.Text,Mail = this.txtEmail.Text };

            this.UsuarioCreado = usuario;

            this.Close();
        }
    }
}
