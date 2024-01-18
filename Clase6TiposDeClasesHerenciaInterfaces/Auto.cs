using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6TiposDeClasesHerenciaInterfaces
{
    public class Auto : Vehiculo, IVehiculo
    {

        public Auto(string numeroDeSerie, string color, float velocidadMaxima, string marca, string modelo)
            : base(numeroDeSerie,color,velocidadMaxima,marca,modelo)
        {

        }
        public void acelerar()
        {
            this.velocidadActual = this.velocidadActual + 10;

            Console.WriteLine("Acelerando auto a {0} km/h", this.velocidadActual);
        }

        public void arrancar()
        {
            Console.WriteLine("Arrancando auto....En Arranque");
        }

        public void detener()
        {
            Console.WriteLine("Deteniendo auto....detenido");
        }
    }
}
