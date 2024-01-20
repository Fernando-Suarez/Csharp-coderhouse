using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8ListasYMatricesActividad1
{
    public class ProductoConE
    {
        private List<Producto> _productosConE;

        public ProductoConE()
        {
            _productosConE = new List<Producto>();
        }

        
        public void InsertarEnLista(Producto[] arrayProductos) 
        {
            for (int i = 0;  i < arrayProductos.Length; i++)
            {
                if (arrayProductos[i].Descripcion.Contains("E") || arrayProductos[i].Descripcion.Contains("e"))  {
                    _productosConE.Add(new Producto (arrayProductos[i].Codigo, arrayProductos[i].Descripcion));
                }
            }
        }
        public List<Producto> MostrarLista()
        {
            return _productosConE;
        }

        public void LimpiarLista()
        {
            _productosConE.Clear();
        }


    }
}
