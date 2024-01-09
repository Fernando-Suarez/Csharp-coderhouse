// See https://aka.ms/new-console-template for more information

//CONSIGNAS

//1. CONDICIONAL SIMPLE
//Supongamos que debemos hacer un control básico del stock de nuestros productos en un depósito.
//Nos brindan la cantidad de productos en depósito y la cantidad de productos vendidos.
//Entonces debemos preguntarnos si no existen productos en nuestro depósito, entonces debemos reponerlos.  
//Aquí utilizamos Console.ReadLine() para obtener la cantidad a vender y seguir trabajando con variables,
//en la cual como dicha función retorna un string y la cantidad es un entero tuvimos que convertir utilizando la función Convert
//que me permite convertir entre diversos tipos de datos.

//2. CONDICIONAL COMPUESTO
//Basándonos en el ejemplo anterior debemos preguntarnos si no existen productos en nuestro depósito, entonces debemos reponerlos.  
//De lo contrario, notificar al área de ventas que aún siguen productos sin vender.
//Nótese que solo existe una condición y dos valores posibles.

//3. CONDICIONAL ANIDADO
//Basándonos en el ejemplo anterior:
//Se debe informar que no existen productos si no hay.
//En caso de Haber productos
//si  hay 5 o menos notificar a Logística que Se encuentra en los márgenes de Stock Mínimo y se debe reponer y informar a ventas que hay disponibilidad para vender
// caso contrario solo informar a ventas que hay disponibilidad para vender.
//Observar que en este caso tenemos dos condiciones, cantidad == 0 por un lado y cantidad <= 5 por otro lado, noten que ya tendremos en este caso al menos 3 resultados posibles. 

//variables 
int productosVendidos;
int productosEnDeposito = 50;
int stock;


//cuerpo del programa

Console.WriteLine("Por favor ingrese los productos vendidos");

productosVendidos = Convert.ToInt32(Console.ReadLine());
stock = productosEnDeposito - productosVendidos;


if(stock == 0)
{
    Console.WriteLine("No existe el producto en stock");
   
}


else if(stock <= 5)
{
    Console.WriteLine("Se encuentra en los márgenes de Stock Mínimo y se debe reponer");
    productosEnDeposito += 10;
    Console.WriteLine("Productos Cargados al Deposito");
}
else
{
    Console.WriteLine("Hay productos disponibles para venta");
}


