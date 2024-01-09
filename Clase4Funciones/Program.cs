//Funciones

//Una función es un bloque de código que contiene un conjunto de instrucciones que se ejecutarán cada vez que la invoquemos. 
//Es decir, es un bloque de código que luego puede reutilizarse a lo largo del todo el código de nuestro programa.


//Ejemplo funcion simple:
//Declaramos una función llamada saludar que no devuelve ningún valor y no posee argumentos; solo realiza un saludo al programa principal.
//En él se realiza dos veces la invocación a la función:


void saludar()
{
    Console.WriteLine("HOLA A TODOS ");
}

saludar(); // Invocar la funcion creada.
saludar();


//Ejemplo funcion con parametros y retorno
//Declaramos la función sumar donde recibe dos argumentos; el primero, es un número de tipo entero llamado “numero01” y el segundo también entero llamado “numero02”.
//Retorna un número entero con el resultado de la operación.
//

int numero1;
int numero2;

Console.WriteLine("Ingrese el primer valor a sumar");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo valor a sumar");
numero2 = int.Parse(Console.ReadLine());

int sumar(int numero01, int numero02) // Dentro de parentesis van los parametros que recibe la funcion
{
    return numero01 + numero02;   // Retorna la suma de los numeros en el tipo de dato int.
}


Console.WriteLine("La suma de {0} + {1} es igual a : {2}", numero1, numero2, sumar(numero1, numero2)) ;