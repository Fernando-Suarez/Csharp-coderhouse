using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6TiposDeClasesHerenciaInterfaces
{
    public class Empleado : Persona  // empleado hereda de la clase persona , :
    {
        protected string legajo;

        public Empleado(string legajo, long dni, string nombre, string domicilioParticular)
            :  base  (dni,nombre,domicilioParticular) // hereda los parametros del constructor de la clase padre y los usa como parametros en la clase hija , : base(atributos de la clase padre)
        {
            this.legajo = legajo;
        }

        public override void mostrarDatos()
        {

            base.mostrarDatos();
            Console.WriteLine("LEGAJO: {0}", legajo);
        }
    }
}
