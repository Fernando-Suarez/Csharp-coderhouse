using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9ConsultaDatosADO_NET_actividadEnClaseForm
{
    internal class Producto
    {
        //Clase: Producto;
        //Propiedades: Id, Descripcion, Costo, PrecioVenta, Stock, IdUsuario

        private int _id;
        private string _descripcion;
        private double _costo;
        private double _precioVenta;
        private string _categoria;
     

        public Producto(int id, string descripcion, double costo, double precioVenta,string categoria)
        {
            _id = id;
            _descripcion = descripcion;
            _costo = costo;
            _precioVenta = precioVenta;
            _categoria = categoria;

        }

        public Producto() 
        {
            
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        public double Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }
        public double PrecioVenta
        {
            get { return _precioVenta; }
            set { _precioVenta = value; }
        }
       
        public string Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }
     
    }
}
