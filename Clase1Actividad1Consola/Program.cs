// See https://aka.ms/new-console-template for more information



//Actividad 1

//Crear un proyecto de consola y nombrarlo como [Desafio1NombreApellido] (nombre y apellido del alumno)
//Luego, guardar los siguientes datos en variables y mostrarlos por consola:
//Nombre:
//Apellido:
//DNI:
//Edad:
//Altura:



//Variables

string nombre;
string apellido;
int DNI;
int edad;
decimal altura;
int numero1 = 0;
int numero2 = 0;
int resultado = 0;
string alias;

Console.WriteLine("Ingrese Su Nombre");
nombre = Console.ReadLine();
Console.WriteLine("Ingrese Su Apellido");
apellido = Console.ReadLine();

// Clase Convert para convertir datos
Console.WriteLine("Ingrese Su DNI");
DNI = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Ingrese Su Edad");
edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese Su Altura en Decimales");
altura = Convert.ToDecimal (Console.ReadLine());

//Console.WriteLine(nombre + " " + apellido +  " "  + DNI + " " + edad + " " + altura);

//Metodo de Interpolacion de cadena

Console.WriteLine($"{nombre} {apellido} {DNI} {edad} {altura} ");


//Actividad 2

//Siguiendo en el mismo proyecto… 
//Ingresar dos números por teclado y luego mostrar el resultado de la suma por consola.


Console.WriteLine("Ingrese un Numero");

numero1 = Convert.ToInt32( Console.ReadLine());

Console.WriteLine("Ingrese un Numero");

numero2 = Convert.ToInt32(Console.ReadLine());

resultado = numero1 + numero2;  

Console.WriteLine($"La suma de los numero 1 y 2 es : {resultado}");

//Actividad 3

//Utilizando las variables nombre y apellido de la actividad 1 . 
//Muestre las dos variables en un solo console.Writeline , poniendo en el medio su alias.
//Por ejemplo en la consola debería verse con este formato:: 
// Mi nombre es : Juan "El Yakuza" Rodriguez

Console.WriteLine("Escriba su Alias");

alias = Console.ReadLine();

Console.WriteLine($"Mi nombre es : {nombre} \"{alias}\" {apellido} ");