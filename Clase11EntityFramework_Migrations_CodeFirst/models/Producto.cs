using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11EntityFramework_Migrations_CodeFirst.models
{
    public class Producto
    {
        private int _id;
        private string _descripcion;
        private double _precioCompra;
        private double _precioVenta;
        private double _stock;
        private double _totalProducto;
        private string _categoria;

        public Producto() { }
        public Producto(int id, string descripcion, double precioCompra, double precioVenta, double stock, double totalProducto, string categoria)
        {
            _id = id;
            _descripcion = descripcion;
            _precioCompra = precioCompra;
            _precioVenta = precioVenta;
            _stock = stock;
            _totalProducto = totalProducto;
            _categoria = categoria;
        }

        public int Id { get => _id; set => _id = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public double PrecioCompra { get => _precioCompra; set => _precioCompra = value; }
        public double PrecioVenta { get => _precioVenta; set => _precioVenta = value; }
        public double Stock { get => _stock; set => _stock = value; }
        public double TotalProducto { get => _totalProducto; set => _totalProducto = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
    }
}
