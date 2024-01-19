using Clase7ListasBasicos;
class Program
{
    static void Main(string[] args)
    {
        // Declaracion de un array
        string[] cadena = new string[3];
        cadena[0] = "Hola mundo 1";
        cadena[1] = "Hola mundo 2";
        cadena[2] = "Hola mundo 3";


        // leer la cadena
        for (int i = 0; i < cadena.Length; i++)
        {

        Console.WriteLine(cadena[i]);
        }

        //Declaracion de un Array Inicializado

    

        string[] razasDePerrosArrayInicializado = { "Buldog", "Bull Terrier Ingles", "Border Collie", "Ovejero Belga" };

        foreach (string item in razasDePerrosArrayInicializado)
        {
            Console.WriteLine(item);
        }


        // Array de objetos 

        Producto[] bebidasGaseosas = 
           {
            new Producto(1,"Coca Cola",1500, 2000, "Gaseosa" ),
            new Producto(2,"Manaos",1000, 1400, "Gaseosa" ),
            new Producto(3,"Fanta",1400, 1900, "Gaseosa" ),
            new Producto(4,"Sprite",1450, 1950, "Gaseosa" )
        };

        //Vemos que para recorrer el array de objetos llamado bebidasGaseosas utilizamos un foreach que, por cada iteración, “copia” el elemento actual leído en la variable bebida.
        //Esta variable podemos usarla y, en este caso, realizar una comparación para obtener el producto más caro según el precio de compra.
        Producto bebidaMasCara = new Producto();

        //Utilizamos un foreach para recorrer el array de Objetos

        foreach (Producto bebida in bebidasGaseosas)
        {
            if(bebida.PrecioCompra > bebidaMasCara.PrecioCompra)
            {
                bebidaMasCara = bebida;
            }
        }

    }
}