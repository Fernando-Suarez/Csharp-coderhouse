using Clase6TiposDeClasesHerenciaInterfaces;
using System;

// implementacion de las clases

class Program
{
    static void Main(string[] args)
    {
        Estudiante estudiante1 = new Estudiante("C#",33222555,"Fernando", "Calle Falsa 123");
        Empleado empleado1 = new Empleado("69145", 33555222, "Claudio", "Calle Falsa 234");


        Persona persona1 = empleado1;
        Persona persona2 = estudiante1;
        Persona persona3 = new Persona(68145,"Juan","Calle Falsa 345");

        // Estudiante estudiante2 = persona1;    -   no puedo asignar una clase padre a una clase hijo;
        persona1.mostrarDatos();
        persona2.mostrarDatos();
        persona3.mostrarDatos();

        //Para acceder al método static se debe comenzar con el nombre de la Clase directamente sin instanciar algún objeto de la misma.
        Console.WriteLine(Persona.TelefonosEmergencia());
        Console.WriteLine(Empleado.TelefonosEmergencia());
        Console.WriteLine(Estudiante.TelefonosEmergencia());
        Console.WriteLine(Administrativo.TelefonosEmergencia());


        // Implementacion de interfaces
        Cubo cubo = new(1);
        Rectangulo rectangulo = new(2, 2);
        Circulo circulo = new(2);

        Console.WriteLine($"Volumen Cubo {cubo.Volumen()} \n Perimetro Rectangulo {rectangulo.Perimetro()} \n Area Circulo {circulo.Area()} ");


        //Se crean dos objetos donde se muestra su información y realizan las funciones básicas de una Vehículo.

        Auto autoFord = new Auto("M23923","Blanco", 200, "Ford", "Fiesta Max");
        Moto motoBMW = new Moto("X3CDS", "Negro", 300, "BMW", "F 900");

        Console.WriteLine(autoFord.ToString());
        autoFord.arrancar();
        autoFord.acelerar();
        autoFord.acelerar();
        autoFord.acelerar();
        autoFord.detener();

        Console.WriteLine(motoBMW.ToString());
        motoBMW.arrancar();
        motoBMW.acelerar();
        motoBMW.acelerar();
        motoBMW.acelerar();
        motoBMW.detener();
    }


}