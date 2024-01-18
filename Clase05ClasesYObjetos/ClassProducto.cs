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
      

        private int _codigo;  // atributos de clase
        private string _descripcion;
        private double _precioCompra;
        private double _precioVenta;
        private string _categoria;
        
        
        //Propiedades con getter and setters
        public int Codigo 
        {
            get {
                // logica
                return this._codigo;
            } 
            set 
            {
                //logica
                this._codigo = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return this._descripcion;
            }
            set
            {
                this._descripcion = value;
            }
        }

        public double PrecioCompra
        {
            get
            {
                return _precioCompra;
            }
            set
            {
                this._precioCompra = value;
            }
        }

        public double PrecioVenta
        {
            get
            {
                return this._precioVenta;
            }
            set
            {
                this._precioVenta = value;
            }
        }

        public string Categoria
        {
            get
            {
                //Logica
                if(string.IsNullOrEmpty(_categoria))
                {
                return this._categoria;
                } else
                {
                    return "Sin Categoria";
                }
            }
        }

        //propiedades autoimplementadas

        // lectura y escritura
        public string Color { get; set; }

        //solo lectura
        public string Modelo { get; }


        //constructor por defecto

        public Producto()
        {
            this._codigo = 0;  // inicializo atributos con el constructor por defecto
            this._descripcion = string.Empty;
            this._precioCompra = 0;
            this._precioVenta = 0;
            this._categoria = string.Empty;
        }

        //constructor parametrizado
        public Producto(int codigo, string descripcion, double precioCompra, double precioVenta, string categoria)
        {
            this._codigo = codigo;
            this._descripcion = descripcion;
            this._precioCompra = precioCompra;
            this._precioVenta = precioVenta;
            this._categoria = categoria;
            
        }

        public bool HayPrecioDeVenta() //metodo empieza con mayuscula
        {
            return this._precioVenta > 0;
        }
    }
}
