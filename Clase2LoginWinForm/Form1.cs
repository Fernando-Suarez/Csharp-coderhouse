namespace Clase2LoginWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ////  Consigna

            ////Nos piden que armemos un programa de consola que valide la contraseña que ingresa el usuario por teclado y nos informe qué perfil tiene el usuario los cuales pueden ser A
            ////para Administrador, U para Usuario y en caso contrario Sin Perfil definido. 
            ////Tener en cuenta que la contraseña debe estar almacenada previamente al momento de la ejecución del programa.
            ////Es “numérica” de ocho dígitos. Así como también el perfil preestablecido que puede ser A, U o X.
            ////Si el acceso es válido, mostrar un mensaje de bienvenida y el perfil del usuario.
            ////De lo contrario, se le pide una vez más la contraseña.
            ////Si el acceso es válido esta última vez, también mostrar un mensaje de bienvenida.
            ////De lo contrario, informar que debe reiniciar el sistema.




            ////Variables
            int pass = 12345678;

            ////Cuerpo del Programa



            if (pass == Convert.ToInt32(txtPass.Text))
            {
                switch (txtUsuario.Text)
                {
                    case "A":
                        lblPerfil.Text = "BIENVENIDO ADMINISTRADOR";
                        break;
                    case "U":
                        lblPerfil.Text = "BIENVENIDO USUARIO";
                        break;
                    default:
                        lblPerfil.Text = "BIENVENIDO SIN PERFIL DEFINIDO";
                        break;
                }
            }
            else
            {
                MessageBox.Show("INGRESE LA CONTRASEÑA NUEVAMENTE");

                if (pass == Convert.ToInt32(txtPass.Text))
                {
                    switch (txtUsuario.Text)
                    {
                        case "A":
                            lblPerfil.Text = "BIENVENIDO ADMINISTRADOR";
                            break;
                        case "U":
                            lblPerfil.Text = "BIENVENIDO USUARIO";
                            break;
                        default:
                            lblPerfil.Text = "BIENVENIDO SIN PERFIL DEFINIDO";
                            break;
                    }
                }
                else
                {
                    lblPerfil.Text = "DEBE REINICIAR EL SISTEMA";
                }
            }

        }
    }
}
