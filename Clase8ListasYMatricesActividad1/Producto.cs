using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8ListasYMatricesActividad1
{
    public class Producto
    {

        public int Codigo {  get; set; }
        public string Descripcion { get; set; }

        public Producto(int codigo, string descripcion) 
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
        }

       
    }
}
