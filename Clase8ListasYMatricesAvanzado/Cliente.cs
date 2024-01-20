using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8ListasYMatricesAvanzado
{
    public class Cliente
    {
        public string Nombre {  get; set; }
        public long Id { get; set; }
        public string Direccion {  get; set; }
        public short Edad {  get; set; }

        public Cliente(string nombre, long id, string direccion, short edad)
        {
            this.Nombre = nombre;
            this.Id = id;
            this.Direccion = direccion;
            this.Edad = edad;
        }
        //Se observa como detalle el método sobrescrito Equals para definir cuando un cliente es igual a otro.
        //Sobrescribir Equals permite que el método IndexOf pueda utilizarlo para realizar la búsqueda de un cliente dentro de la lista y devolver la posición del mismo en ella

        public override bool Equals(object? obj)
        {
            Cliente cliente = (Cliente)obj;
            return this.Id.Equals(cliente.Id);
                
        }
    }
}
