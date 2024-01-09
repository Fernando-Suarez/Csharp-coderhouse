//Descripción de la actividad. 

//Nuestro cliente solicita que se valide el acceso a través de una contraseña  a su sistema… pero con una condición,
//que el usuario solo pueda reintentar ingresar solamente 5 veces. Si la cantidad de intentos es mayor, informar que no es posible acceder al sistema y el mismo se cerrará.
//La contraseña seteada es “usSystem-2022” y el usuario debe ingresar por teclado para hacer la comparación.
//Si el usuario accede correctamente mostrará un mensaje de bienvenida. 


//Variables

string password = "usSystem-2022";
string passwordUser;
int contador = 5;


//Cuerpo del programa



for (int i = 1; i < 6; i++)
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
        contador--;
        Console.WriteLine("CONTRASEÑA INCORRECTA, LE QUEDAN {0} INTENTOS", contador);
    }



}



