using Clase12EntityFrameworkManipulacionDatos_Form.models;
using Clase12EntityFrameworkManipulacionDatos_Form.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Clase12EntityFrameworkManipulacionDatos_Form.service
{
    public static class ProductoService
    {

        public static bool EliminarProducto(int id)
        {
            using (CoderContext context = new CoderContext())
            {
                Producto? producto = context.Productos.Include((p) => p.ProductoVendidos).Where((p) => p.Id == id).FirstOrDefault();
                if (producto != null)
                {
                    context.Remove(producto);
                    context.SaveChanges();
                    return true;
                }
                return false;

            }

        }

    }
}
