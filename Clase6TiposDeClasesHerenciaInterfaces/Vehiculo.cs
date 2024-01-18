using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6TiposDeClasesHerenciaInterfaces
{
    public abstract class Vehiculo
    {
        public string numeroDeSerie { get; set; }

        public string color { get; set; }

        public float velocidadMaxima { get; set; }

        public string marca { get; set; }

        public string modelo { get; set; }

        protected float velocidadActual { get; set; }

        public Vehiculo(string numeroDeSerie, string color, float velocidadMaxima, string marca, string modelo)
        {
            this.numeroDeSerie = numeroDeSerie;
            this.color = color;
            this.velocidadMaxima = velocidadMaxima;
            this.marca = marca;
            this.modelo = modelo;
            this.velocidadActual = 0;
        }

        public override string ToString()
        {
            return $"Numero de Serie : {this.numeroDeSerie} \n Color : {this.color} Velocidad Maxima : {this.velocidadMaxima} Marca : {this.marca} Modelo : {this.modelo}";
        }
    }
}
