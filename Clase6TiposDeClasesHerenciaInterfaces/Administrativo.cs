using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6TiposDeClasesHerenciaInterfaces
{
    //transitividad  - ahora  la clase administrativo hereda de  la clase empleado que a su vez hereda de la clase persona
    internal class Administrativo : Empleado
    {
        public Administrativo(string legajo, long dni , string nombre, string domicilioParticular)
            : base (legajo,dni,nombre,domicilioParticular)
        {

        }
    }
}
