using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6TiposDeClasesHerenciaInterfaces
{
    public class Estudiante : Persona
    {
        //propiedad exclusiva de un empleado
        protected string carrera;

        public Estudiante(string carrera, long dni, string nombre, string domicilioParticular) 
            : base (dni,nombre,domicilioParticular) 
        {
            this.carrera = carrera;
        }

        // override indica que aqui se va a sobreescribir el metodo virtual declarado en la clase base.

        public override void mostrarDatos()
        {
            //puedo usar las instrucciones del metodo heredado
            base.mostrarDatos();//con el comando base hago referencia alos datos y metodos de la clase base
            //y agregar la nueva logica o tambien puedo omitir base.mostrarDatos()
            //y sobreescribir completamente con mi logica

            Console.WriteLine("CARRERA : {0}", carrera);
        }
    }
}
