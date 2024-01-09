

//While -  El funcionamiento del bucle while se resume en: mientras que no se cumpla la condición indicada, repite las instrucciones incluidas dentro del bucle.

//ejemplo:
//Console.WriteLine("Ingrese contraseña");

//string contraseñaIngresada = Console.ReadLine();


//while (!contraseñaIngresada.Equals("Coder!house2024"))
//{
//    Console.WriteLine("contraseña incorrecta, vuelva a ingresar la contraseña");
//    contraseñaIngresada = Console.ReadLine();
//}

//Console.WriteLine("Ingresaste al Sistema");



//For - El funcionamiento del bucle for se resume en: Para una cierta variable de control,
//repetir hasta la condición de fin y avanzar incrementando la variable X pasos por cada repetición.


//ejemplo
//¡Nos piden que a través de una app podamos calcular el promedio de notas de un alumno de Coderhouse! Debemos calcularlo en base a la cantidad de notas ingresadas.
//Luego, imprimimos por pantalla.
//Noten que hay validaciones que no se están realizando y pueden provocar errores en la ejecución


//int i; //variable de control
//int cantidadDeNotasACargar = 0;
//double nota;
//double sumaDeNotas = 0;
//double promedioDeNotas = 0;
//bool aplazado = false; 


//Console.WriteLine("Ingrese la cantidad de notas a cargar");

//cantidadDeNotasACargar =int.Parse(Console.ReadLine());
//while (cantidadDeNotasACargar <= 0)
//{
//    Console.WriteLine("La cantidad no puede ser 0 o menor");
//    cantidadDeNotasACargar = int.Parse(Console.ReadLine());
//}


//    for (i = 1; i <= cantidadDeNotasACargar; i++)
//    {
//        Console.WriteLine("Ingrese la Nota:");
//        nota = double.Parse(Console.ReadLine());
//        while (nota < 0)
//        {
//            Console.WriteLine("La nota no puede ser menor que 0");
//            nota = double.Parse(Console.ReadLine());
//        }
//        if (nota <= 2)
//    {
//        aplazado = true;
//        break;  // corta con la ejecucion del ciclo y sigue la linea que esta afuera del ciclo. 
//    }
//    //    if (nota > 2 && nota < 4)
//    //{
//    //    cantidadDeNotasACargar--; // quitamos la nota para que no afecte al promedio
//    //    continue;
//    //}
//        sumaDeNotas += nota; // si se ejecuta el continue salta esta linea y vuelve al ciclo

//    }

//    if (aplazado)
//{
//    Console.WriteLine("El alumno fue aplazado por tener una nota igual o menor a 2");
//} else
//{
//    promedioDeNotas = sumaDeNotas / cantidadDeNotasACargar;

//    Console.WriteLine("El Prodedio de las {0} notas es : {1:N2}", cantidadDeNotasACargar, promedioDeNotas);
//}




//variable y condicionales en un ciclo while

//Dada una serie infinita de números ingresados por teclado, determinaremos si son negativos o positivos. Si el usuario ingresa un 0, termina el programa. 
//Recuerden, debemos pensar la condición del while a la inversa de lo que plantea la lógica del problema.

//int numeroIngresado;
//Console.WriteLine( "Clasificador de Numeros Positivos y Negativos");
//Console.WriteLine("Ingresa un numero (0 para salir)");
//numeroIngresado = int.Parse( Console.ReadLine());

//while (numeroIngresado != 0)
//{
//        if (numeroIngresado > 0)
//    {
//        Console.WriteLine("El numero es positivo");

//    } else
//    {
//        Console.WriteLine("El numero es negativo");

//    }
//    Console.WriteLine("Ingresa un numero (0 para salir)");
//    numeroIngresado = int.Parse(Console.ReadLine());
//}



//variable y condicionales en un ciclo for

//Recuerden que el operador % devuelve el resto de una división (en este caso el divisor es 5). Para que un número sea múltiplo de otro su resto debe ser 0.
//La variable de entrada (numeroTopeMultiplos) en la condición de fin del ciclo. 


int numeroTopeMultiplos;
Console.WriteLine("Clasificador de Numeros Multiplos de 5");
Console.WriteLine("Ingresa un numero tope para calcular los multiplos de 5");
numeroTopeMultiplos = int.Parse(Console.ReadLine());
Console.WriteLine("Los numeros multiplos de 5 son: ");

for (int i = 1; i < numeroTopeMultiplos; i++)
{
    if (i % 5 == 0)
    {
        Console.WriteLine(i + ",");
    }
}

