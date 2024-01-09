// See https://aka.ms/new-console-template for more information



//  Consigna

//Nos piden que armemos un programa de consola que valide la contraseña que ingresa el usuario por teclado y nos informe qué perfil tiene el usuario los cuales pueden ser A
//para Administrador, U para Usuario y en caso contrario Sin Perfil definido. 
//Tener en cuenta que la contraseña debe estar almacenada previamente al momento de la ejecución del programa.
//Es “numérica” de ocho dígitos. Así como también el perfil preestablecido que puede ser A, U o X.
//Si el acceso es válido, mostrar un mensaje de bienvenida y el perfil del usuario.
//De lo contrario, se le pide una vez más la contraseña.
//Si el acceso es válido esta última vez, también mostrar un mensaje de bienvenida.
//De lo contrario, informar que debe reiniciar el sistema.




//Variables
int pass = 12345678;
int verificacionPass;
string perfil;

//Cuerpo del Programa

Console.WriteLine("INGRESE SU PERFIL");
perfil = Console.ReadLine();
Console.WriteLine("INGRESE SU CONTRASEÑA");
verificacionPass = Convert.ToInt32(Console.ReadLine());

if (pass == verificacionPass)
{
    switch (perfil)
    {
        case "A": Console.WriteLine("BIENVENIDO ADMINISTRADOR");
            break;
        case "U": Console.WriteLine("BIENVENIDO USUARIO");
            break;
        default: Console.WriteLine("BIENVENIDO SIN PERFIL DEFINIDO");
            break;
    }
} else
{
    Console.WriteLine("INGRESE SU CONTRASEÑA");
    verificacionPass = Convert.ToInt32(Console.ReadLine());

    if (pass == verificacionPass)
    {
        switch (perfil)
        {
            case "A":
                Console.WriteLine("BIENVENIDO ADMINISTRADOR");
                break;
            case "U":
                Console.WriteLine("BIENVENIDO USUARIO");
                break;
            default:
                Console.WriteLine("BIENVENIDO SIN PERFIL DEFINIDO");
                break;
        }
    } else
    {
        Console.WriteLine("DEBE REINICIAR EL SISTEMA");
    }
}









