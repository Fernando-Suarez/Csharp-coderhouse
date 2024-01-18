using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


//Creación de usuario: 
//Se debe crear como clase un "Usuario" con los atributos: Nombre, Apellido, DNI, mail, edad y domicilio.
//Dicha clase debe contener al menos 3 métodos(además del constructor).
//Pueden guiarse con estos ejemplos: 
//EsMayorDeEdad(), CambiarDireccion(), EsGmail(), etc.

namespace Clase5ClasesYObjetosActividad
{
    public class Usuario
    {

        //constructores
        public Usuario()
        {
            Nombre = String.Empty;
            Apellido = String.Empty;
            Dni = 0;
            Mail = String.Empty;
            Edad = 0;
            Domicilio = String.Empty;
        }

        public Usuario(string nombre, string apellido, int dni, string mail, int edad, string domicilio)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Mail = mail;
            Edad = edad;
            Domicilio = domicilio;
        }

        //propiedades autoimplementadas
        public string Nombre {get;set;}
        public string Apellido { get; set; }
        public long Dni { get; set; }
        public string Mail { get; set; }
        public int Edad { get; set; }
        public string Domicilio { get; set; }


        //metodos

        public void EsMayorDeEdad()
        {
            if (this.Edad > 18)
            {
                Console.WriteLine( "Es mayor de edad");
            } else
            {
                Console.WriteLine("No es mayor de edad");
            }
        } 
        public void CambiarDireccion(string direccion)
        {
            this.Domicilio = direccion;
            Console.WriteLine("la nueva direccion es {0}", this.Domicilio);
        } 
        public void EsGmail()
        {
               if ( this.Mail.Contains("@gmail.com"))
            {
                Console.WriteLine("Es una cuenta de Gmail");
                
            } else
            {
                Console.WriteLine("No es una cuenta de Gmail");
            }
        }
    }

}
