using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6TiposDeClasesHerenciaInterfaces
{
    public class Circulo : I2DmedidasCalculables
    {
        double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(this.radio, 2);
        }

        public double Perimetro()
        {
            return 2 * Math.PI * this.radio;
        }
    }
}
