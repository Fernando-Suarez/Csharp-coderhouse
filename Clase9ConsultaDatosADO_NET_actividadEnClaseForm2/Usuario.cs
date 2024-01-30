using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Clase9ConsultaDatosADO_NET_actividadEnClaseForm2
{
    public class Usuario
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private string _password;
        private string _email;



        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string password, string email)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
            _nombreUsuario = nombreUsuario;
            _password = password;
            _email = email;
        }

        public Usuario()
        {
            _id = 0;
            _nombre = string.Empty;
            _apellido = string.Empty;
            _nombreUsuario = string.Empty;
            _password = string.Empty;
            _email = string.Empty;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }




    }
}
