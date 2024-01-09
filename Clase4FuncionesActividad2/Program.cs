//REALIZAR UNA VENTA
//Se pide realizar un programa que resuelva la  venta de productos de una tienda. 
//¡Atento! Debes implementar todo lo visto en clase hasta ahora
//Descripción de la actividad. 
//Una tienda de artículos de limpieza desea realizar la venta de sus productos a través de una aplicación.
//Su cliente debe seleccionarlos de acuerdo al siguiente listado:

//Código     Descripción      Precio
// DES       Desodorante       200
// JP       Jabón en polvo     300
// DET        Detergente       250


//Descripción del proceso de venta. 

//Sus clientes deben ingresar el código del producto y  la cantidad requerida por teclado .
//Si el cliente ingresa el código “FIN”, el programa debe informar el monto que debe abonar .
//Luego el cliente debe Confirmar la compra, si la compra es confirmada, el programa debe mostrar un mensaje “Gracias por comprar en nuestra tienda”.
//De lo contrario el sistema debe finalizar.   



//Variables


//string codigo = "";
//int cantidad;
//int montoFinal = 0;
//int precio = 0;
//string confirmacion;


////Cuerpo del Programa


//vender();
//void vender()
//{

//    Console.WriteLine("Bienvenido, estos son nuestros productos:");
//    Console.WriteLine("Código     Descripción      Precio\r\n DES       Desodorante       200\r\n JP       Jabón en polvo     300\r\n DET        Detergente       250");

//    while (codigo != "FIN")
//    {
//        Console.WriteLine("Ingrese el codigo del producto que desea comprar o FIN para finalizar la compra.");
//        codigo = Console.ReadLine().ToUpper();
//        if (codigo == "FIN")
//        {
//            break;
//        }
//        switch (codigo)
//        {
//            case "DES":
//                precio = 200;
//                break;
//            case "JP":
//                precio = 300;
//                break;
//            case "DET":
//                precio = 250;
//                break;
//            default: 
//                ;
//                break;
//        }     
//        Console.WriteLine("Ingrese la cantidad que desea comprar");
//        cantidad = int.Parse(Console.ReadLine());
//        montoFinal += precio * cantidad;
//    }

//    Console.WriteLine("Su monto a pagar es de {0}", montoFinal);
//    Console.WriteLine("Desea realizar la compra? Si/No");
//    confirmacion = (Console.ReadLine()).ToUpper();
//    if (confirmacion == "SI")
//    {
//        Console.WriteLine("Gracias por comprar en nuestra tienda");
//    }

//}



//variables 




// Solucion CoderHouse...



Console.WriteLine("Bienvendios a mi Tienda... ");
codigoProductoSeleccionado = obtieneCodigoDeProducto();
while (!finDeCompra(codigoProductoSeleccionado, codigoFinDeCompra))
{
    montoTotal = montoTotal + calculoMontoProducto(codigoProductoSeleccionado);
    codigoProductoSeleccionado = obtieneCodigoDeProducto();

}
Console.WriteLine("El monto total de su compra es {0}", montoTotal);
if(confirmaCompra())
{
    Console.WriteLine("Gracias por comprar en nuestra tienda !!");
} else
{
    Console.WriteLine("Su compra ha sido cancelada, El sistema de cerrará...");
}