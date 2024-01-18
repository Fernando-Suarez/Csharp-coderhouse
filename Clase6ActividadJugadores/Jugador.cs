using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6ActividadJugadores
{
    public abstract class Jugador
    {
        public int velocidad { get; set; }
        public int tiro { get; set; }
        public int regate{ get; set; }
        public int defensa { get; set; }
        public int pase { get; set; }
        public int fisico { get; set; }

        public Jugador(int velocidad, int tiro, int regate, int defensa, int pase, int fisico)
        {
            this.velocidad = velocidad;
            this.tiro = tiro;
            this.regate = regate;
            this.defensa = defensa;
            this.pase = pase;
            this.fisico = fisico;
        }

    }
}
