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

            ////Nos piden que armemos un programa de consola que valide la contrase�a que ingresa el usuario por teclado y nos informe qu� perfil tiene el usuario los cuales pueden ser A
            ////para Administrador, U para Usuario y en caso contrario Sin Perfil definido. 
            ////Tener en cuenta que la contrase�a debe estar almacenada previamente al momento de la ejecuci�n del programa.
            ////Es �num�rica� de ocho d�gitos. As� como tambi�n el perfil preestablecido que puede ser A, U o X.
            ////Si el acceso es v�lido, mostrar un mensaje de bienvenida y el perfil del usuario.
            ////De lo contrario, se le pide una vez m�s la contrase�a.
            ////Si el acceso es v�lido esta �ltima vez, tambi�n mostrar un mensaje de bienvenida.
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
                MessageBox.Show("INGRESE LA CONTRASE�A NUEVAMENTE");

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
