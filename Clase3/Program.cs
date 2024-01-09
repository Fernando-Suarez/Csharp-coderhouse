// See https://aka.ms/new-console-template for more information


// Cadenas nulas o vacias

string cadenaCompleta = "Hola soy una cadena";
string cadenaNula = null;
string cadenaVacia = String.Empty;



// Concatenamos una cadena completa , una nula y una vacia , en la salida veremos "Hola soy una cadena"

Console.WriteLine(cadenaCompleta + " " + cadenaVacia + " " + cadenaNula);


if (cadenaNula == cadenaVacia)
{
    Console.WriteLine("Cadena nula y Cadena vacia son iguales????");
} else
{
    Console.WriteLine("Cadena nula y Cadena vacia no son lo mismo");
}


//Funciones para manejo de Cadenas length, ToLower, ToUpper, equals, contain, ToString, Parse

// Length - cuenta cuantos caracteres hay en una cadena
Console.WriteLine(cadenaCompleta.Length);    // 19
Console.WriteLine(cadenaVacia);   // 0


//ToLowerCase - convierte todo a minuscula

Console.WriteLine(cadenaCompleta.ToLower());  //   "hola soy una cadena"


//ToUpperCase - convierte todo a mayuscula  

Console.WriteLine(cadenaCompleta.ToUpper());    // "HOLA SOY UNA CADENA" 


// ToString - convierte el contenido de la variable al tipo de dato string

int numero = 19;
double pi = 3.1416;
bool verdadero = true;

Console.WriteLine(numero.ToString() + " " + pi.ToString() + " " + verdadero.ToString());


//Equals -  nos permite saber si una cadena es estrictamente igual a la otra

string cadenaEquals1 = "soy una cadena  ";
string cadenaEquals2 = "soy una cadena";

if (cadenaEquals1.Equals(cadenaEquals2))
{
    Console.WriteLine(" cadena 1 es igual a cadena 2");
} else
{
    Console.WriteLine("cadena 1 no es igual a cadena 2");
}

//Contains - nos permite saber si una cadena se encunetra dentro de la otra

if (cadenaEquals1.Contains(cadenaEquals2))
{
    Console.WriteLine("cadena 1 contiene a cadena 2");
}else
{
    Console.WriteLine("cadena 1 no contiene a cadena 2");
}


//Parse

Console.WriteLine("Ingrese un numero decimal");

string cadenaANumero = Console.ReadLine();


double constante = 0.5;
double numeroEnCadenaConvertidoADouble;
double sumaConNumerosDouble;

if (String.IsNullOrEmpty(cadenaANumero))
{
    Console.WriteLine("La cadena no se puede parsear por esta vacio o es nula");
} else
{
    numeroEnCadenaConvertidoADouble = double.Parse(cadenaANumero);
    sumaConNumerosDouble = numeroEnCadenaConvertidoADouble + constante;
    Console.WriteLine("El Resultado es : " + sumaConNumerosDouble.ToString());
}