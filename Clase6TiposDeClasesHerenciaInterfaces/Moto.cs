using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6TiposDeClasesHerenciaInterfaces
{
    public class Moto : Vehiculo, IVehiculo
    {
        public Moto(string numeroDeSerie, string color, float velocidadMaxima, string marca, string modelo)
           : base(numeroDeSerie, color, velocidadMaxima, marca, modelo)
        {

        }
        public void acelerar()
        {
            this.velocidadActual = this.velocidadActual + 5;

            Console.WriteLine("Acelerando moto a {0} km/h", this.velocidadActual);
        }

        public void arrancar()
        {
            Console.WriteLine("Arrancando moto....En Arranque");
        }

        public void detener()
        {
            Console.WriteLine("Arrancando moto....En Arranque");
        }
    }
}
