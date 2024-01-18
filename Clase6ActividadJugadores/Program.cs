//Se debe crear la Clase abstracta Jugador y una jerarquía de Clases derivadas para organizar el comportamiento de Messi y Ronaldo. 
//A su vez, el comportamiento debe ser implementado mediante una Interfaz IJugador.
//IMPORTANTE:
//Atributos heredados: Velocidad, Tiro, Regate, Defensa, Pase, Físico. 
//Métodos: uno por cada propiedad, para imprimir el nombre del jugador y la acción más el número de propiedad.
//Ej: "Ronaldo corrió a la velocidad de 87".



using Clase6ActividadJugadores;

class Program
{
    static void Main(string[] args)
    {
        Messi messi = new Messi(98, 89, 95, 15, 98, 50);
        Ronaldo ronaldo = new Ronaldo(88,95,89,20,90,78);

        messi.correr();
        messi.defender();
        messi.regatear();
        messi.rematar();
        messi.colocarPase();
        messi.soportarEmbate();

        ronaldo.correr();
        ronaldo.defender();
        ronaldo.regatear();
        ronaldo.rematar();
        ronaldo.colocarPase();
        ronaldo.soportarEmbate();
    }
}