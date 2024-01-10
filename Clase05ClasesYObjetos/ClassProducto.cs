using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Creación de la clase Producto. A medida que vayamos avanzando en la clase iremos desarrollándola.
//La clase tendrá 5 atributos: 
//código,
//descripción,
//precio de compra,
//precio de venta  
//categoría. 


//Comenzamos definiendo  la Clase producto indicando que los atributos solo serán visibles dentro de la clase.
//Para que otra clase pueda interactuar con nuestra clase, se deben crear métodos que nos permitan obtener y editar los valores según el problema que debemos resolver

namespace Clase5ClasesYObjetos   // namespace es un agrupador logico de clases
{
   
    
    public class Producto   // modificador de acceso + palabra reservada "class" + nombre de la clase con la primera letra en mayuscula
    {
      
        // con getter and setters

        private int _codigo;  // atributos de clase
        private string _descripcion;
        private double _precioCompra;
        private double _precioVenta;
        private string _categoria;

        //constructor por defecto

        public Producto()
        {
            _codigo = 0;  // inicializo atributos con el constructor por defecto
            _descripcion = string.Empty;
            _precioCompra = 0;
            _precioVenta = 0;
            _categoria = string.Empty;
        }

        public Producto(int codigo, string descripcion, double precioCompra, double precioVenta, string categoria)
        {
            this._codigo = codigo;
            this._descripcion = descripcion;
            this._precioCompra = precioCompra;
            this._precioVenta = precioVenta;
            this._categoria = categoria;
            
        }
    }
}
