using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6TiposDeClasesHerenciaInterfaces
{
    public class Persona   // Modificador de estado + la palabra reservada "class" + nombre de la clase
    {
        //Atributos
        protected long dni;
        protected string nombre;
        protected string domicilioParticular;



        public Persona()  //constructor
        {
            this.dni = 0;
            this.nombre = String.Empty;
            this.domicilioParticular = String.Empty;

        }

        public Persona(long dni, string nombre, string domicilioParticular) // constructor parametrizado
        {
            this.dni = dni;
            this.nombre = nombre;
            this.domicilioParticular = domicilioParticular;
        }

        //virtual es un modificador que indica que un metodo se puede sobreescribir en una clase deriva si se quiere
        public virtual void mostrarDatos()
        {
            Console.WriteLine($"DNI : {dni} \n NONMBRE: {nombre} \n DOMICILIO PARTICULAR: {domicilioParticular} ");
        }

        //static significa que yo puedo invocar la clase
        //metodo o atributo sin instancia la clase a la cual se le agrega su modificador.

        public static string TelefonosEmergencia()
        {
            return "100 - Bomberos / 101 - Policia / 103 - Defensa civil / 105 - Emergencia Ambiental";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) 
            {
                return false;
            }
            Persona persona = (Persona)obj;
            return this.dni == persona.dni;
        }
    }
}
