using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6ActividadJugadores
{
    public class Ronaldo : Jugador, IJugador
    {
        public Ronaldo(int velocidad, int tiro, int regate, int defensa, int pase, int fisico)
            : base(velocidad, tiro, regate, defensa, pase, fisico)
        {
        
        }
        public void colocarPase()
        {
            Console.WriteLine("Cristiano Ronaldo coloco un pase con {0} de propiedad", this.pase);
        }

        public void correr()
        {
            Console.WriteLine("Cristiano Ronaldo corrio con {0} de propiedad", this.velocidad);
        }

        public void defender()
        {
            Console.WriteLine("Cristiano Ronaldo defendio con {0} de propiedad", this.defensa);
        }

        public void regatear()
        {
            Console.WriteLine("Cristiano Ronaldo regateo con {0} de propiedad", this.regate);
        }

        public void rematar()
        {
            Console.WriteLine("Cristiano Ronaldo remato con {0} de propiedad", this.tiro);
        }

        public void soportarEmbate()
        {
            Console.WriteLine("Cristiano Ronaldo soporto el embate con {0} de propiedad", this.fisico);
        }
    }
}
