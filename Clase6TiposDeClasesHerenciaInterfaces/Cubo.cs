using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6TiposDeClasesHerenciaInterfaces
{
    public class Cubo : FiguraGeometrica , I3DmedidasCalculables
    {

        double lado;

        public Cubo(double lado)
        {
            this.lado = lado;
        }
       
        public override double Area()
        {
            return 6 * Math.Pow(lado, 2);
        }

        public override double Perimetro()
        {
            return 12 * lado;
        }

        public double Volumen()
        {
            return Math.Pow(lado, 3);
        }
    }
}
