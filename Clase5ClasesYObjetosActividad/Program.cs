using Clase5ClasesYObjetosActividad;

//Descripción de la actividad. 
//Ahora debemos implementar nuestra clase Usuario dentro un método Main para crear instancias de usuarios mediante el constructor
//y utilizar los métodos de la clase para mostrar su comportamiento. No se olviden de mostrar los resultados por pantalla.  


class RegistroUsuario
{
    static void Main(string[] args)
    {
        Usuario usuario1 = new Usuario();
        Usuario usuario2 = new Usuario("Carlos", "Perez", 30232214, "prueba@gmail.com", 17, "calle 1");
        Usuario usuario3 = new Usuario("pepe", "gomez", 33120120, "prueba@yahoo.com", 78, "calle 2");


        Console.WriteLine("Ingrese el nombre");
        usuario1.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el apellido");
        usuario1.Apellido = Console.ReadLine();
        Console.WriteLine("Ingrese el dni");
        usuario1.Dni = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el mail");
        usuario1.Mail = Console.ReadLine();
        Console.WriteLine("Ingrese la edad");
        usuario1.Edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el domicilio");
        usuario1.Domicilio = Console.ReadLine();


        Console.WriteLine($"El usuario 1 {usuario1.Nombre} es mayor de edad?");
        usuario1.EsMayorDeEdad();
        Console.WriteLine($"El usuario 2 {usuario2.Nombre} tiene la cuenta en gmail?");
        usuario2.EsGmail();
        Console.WriteLine($"El usuario 2 {usuario1.Nombre} tiene la cuenta en gmail?");
        usuario1.EsGmail();
        Console.WriteLine($"El usuario 2 {usuario2.Nombre} tiene domicilio en {usuario2.Edad}  {usuario3.Edad}");
        Console.WriteLine(usuario1.Edad);
        usuario2.CambiarDireccion("calle 15465784");

    }
}