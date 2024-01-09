//Actividad Validando Acceso Recargado

//Utilizar los 2 bucles armados  de la versión anterior de “Validar acceso” y armar 2 funciones para cada uno.
//Lograr, uniendo estas 2 funciones que se intente escribir la contraseña actual (en caso de error repetir la petición),
//y que si da con la correcta el sistema debe imprimir su número de caracteres en forma de asterisco seguido de la frase "es correcta" quedando de la siguiente manera:
// "****** es correcta".


//Variables

string password = "usSystem-2022";
string passwordUser;
int contador = 5;



//Cuerpo del Programa

verificarContraseña();
void verificarContraseña()
{

    for (int i = 0; i <= 5; i++)
    {
        Console.WriteLine("INGRESE CONTRASEÑA");
        passwordUser = Console.ReadLine();

        if (password.Equals(passwordUser))
        {
            Console.WriteLine("INGRESASTE AL SISTEMA");
            break;
        }
        else if (i >= 5)
        {
            Console.WriteLine("NO ES POSIBLE ACCEDER AL SISTEMA Y EL MISMO SE CERRARA");
            break;
        }
        else
        {
            Console.WriteLine("CONTRASEÑA INCORRECTA, LE QUEDAN {0} INTENTOS", contador);
            contador--;
        }



    }
}