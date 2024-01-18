using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6ProyectoFinalPrimerosPasos
{
    public class Venta
    {
        //Clase: Venta;
        //Propiedades: Id, Comentarios, IdUsuario

        private int _id;
        private string _comentarios;
        private string _idUsuario;

        public Venta(int id, string comentarios, string idUsuario)
        {
            _id = id;
            _comentarios = comentarios;
            _idUsuario = idUsuario;
        }

        public int Id 
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Comentarios
        {
            get { return _comentarios; }
            set { _comentarios = value;}
        }
        public string IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
    }
}
