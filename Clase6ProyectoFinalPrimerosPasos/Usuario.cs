using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6ProyectoFinalPrimerosPasos
{
    public class Usuario
    {
        //Clase: Usuario;
        //Propiedades: Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail 
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private string _password;
        private string _email;

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string password, string email)
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._nombreUsuario = nombreUsuario;
            this._password = password;
            this._email = email;
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
        { get { return _password; }
          set { _password = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }


    }
}
