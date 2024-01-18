using Clase5ClasesYObjetos; // usar el namespace donde se encuentra la clase con la palabra reservada using + namespace
class ProbarObjetosYClases { static void Main(string[] args) { 
//Creación de la clase Producto. A medida que vayamos avanzando en la clase iremos desarrollándola.
//La clase tendrá 5 atributos: 
//código,
//descripción,
//precio de compra,
//precio de venta  
//categoría. 


//Comenzamos definiendo  la Clase producto indicando que los atributos solo serán visibles dentro de la clase.
//Para que otra clase pueda interactuar con nuestra clase, se deben crear métodos que nos permitan obtener y editar los valores según el problema que debemos resolver




//crear una instancia de una clase (objeto)

//constructor por defecto
Producto producto = new Producto();

//constructor parametrizado
Producto producto2 = new Producto(50285, "caramelo chupado", 10.00, 15.00, "Golosina");
        Console.WriteLine(producto.Codigo);
        producto.Color = "rojo";
        Console.WriteLine(producto.Color);
        Console.WriteLine(producto2.Color);
        Console.WriteLine(producto2.Codigo);
        // uso del metodo de la instancia
        bool tienePrecio1 = producto.HayPrecioDeVenta();

Console.WriteLine(producto2.Descripcion);
producto2.Descripcion = "caramelo";
Console.WriteLine(producto2.Descripcion);
//getter se obtiene con la notacion de punto el atributo
Console.WriteLine("el codigo de producto es : " + producto2.Codigo);


Console.WriteLine("Ingrese un codigo");
producto.Codigo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(producto.Codigo);
    }
}