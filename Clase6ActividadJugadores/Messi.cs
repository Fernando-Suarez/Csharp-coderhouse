using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6ActividadJugadores
{
    public class Messi : Jugador, IJugador
    {

        public Messi(int velocidad, int tiro, int regate, int defensa, int pase, int fisico)
            : base(velocidad, tiro, regate, defensa, pase, fisico)
        { 
        
        }
        public void colocarPase()
        {
            Console.WriteLine("Lionel Messi coloco un pase con {0} de propiedad",this.pase);
        }

        public void correr()
        {
            Console.WriteLine("Lionel Messi corrio con {0} de propiedad", this.velocidad);
        }

        public void defender()
        {
            Console.WriteLine("Lionel Messi defendio con {0} de propiedad", this.defensa);
        }

        public void regatear()
        {
            Console.WriteLine("Lionel Messi regateo con {0} de propiedad", this.regate);
        }

        public void rematar()
        {
            Console.WriteLine("Lionel Messi remato con {0} de propiedad", this.tiro);
        }

        public void soportarEmbate()
        {
            Console.WriteLine("Lionel Messi soporto el embate con {0} de propiedad", this.fisico);
        }
    }
}
