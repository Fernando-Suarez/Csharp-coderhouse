using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8ListasYMatricesAvanzado
{

    //Comenzamos con la clase que contiene a los clientes mayores de edad desde el array precargado en la Clase Implementación.

    
    
    public class ListaMayores
    {
        private List<Cliente> _clientesMayores;
        public ListaMayores()
        {
            _clientesMayores = new List<Cliente>();
        }
        public List<Cliente> GetListaClientes()
        {
            return _clientesMayores;
        }


        //En el método agregar, utilizamos Add para agregar un cliente a la lista y en el método borrar usamos Contains para verificar que se encuentre en la lista
        public void InsertarEnLista(Cliente[] clientes)
        {
            for(int i = 0; i < clientes.Length; i++)
            {
                _clientesMayores.Add(new Cliente(clientes[i].Nombre,
                                                 clientes[i].Id,
                                                 clientes[i].Direccion,
                                                 clientes[i].Edad));
            }
        }
        //y luego procedemos a borrarlo con Remove
        public bool Borrar(Cliente cliente)
        {
            if(!_clientesMayores.Contains(cliente))
            {
                return false;
            }
            return _clientesMayores.Remove(cliente);
        }
        //En Modificar buscamos con IndexOf la posición del cliente a modificar y accedemos de forma directa para reemplazar la información.
        public int Buscar(Cliente cliente)
        {
            return _clientesMayores.IndexOf(cliente);
        }

        //Se valida que la búsqueda no devuelva resultado o que el cliente nuevo no sea mayor de edad.
        public bool Modificar(Cliente actual,Cliente nuevo)
        {
            int posicion = Buscar(actual);
            if(posicion < 0)
            {
                return false;
            }
            _clientesMayores[posicion] = nuevo;
            return true;
        }

        //Se puede eliminar todos los elementos de la lista con el método LimpiarLista
        public void LimpiarLista()
        {
            _clientesMayores.Clear();
        }


        //El método en cuestión es CompararClientes donde decidimos que los Clientes se comparen por el ID.

        public int CompararClientes(Cliente cliente1, Cliente cliente2)
        {
            return cliente1.Id.CompareTo(cliente2.Id);
        }

        //La particularidad la tenemos en el método Ordenar. El método Sort recibe como parámetro “un método” que luego utiliza internamente para generar el
        //ordenamiento de la lista.
        public void Ordenar()
        {
            _clientesMayores.Sort(CompararClientes);
        }



    }

}
