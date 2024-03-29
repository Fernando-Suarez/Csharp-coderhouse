﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11DesafioEntregable_AccesoADatos_ADO_console.Models
{
    public class Venta
    {
        //Propiedades: Id, Comentarios, IdUsuario
        private int _id;
        private string _comentarios;
        private int _idUsuario;

        public Venta() { }
        public Venta(int id, string comentarios, int idUsuario)
        {
            _id = id;
            _comentarios = comentarios;
            _idUsuario = idUsuario;
        }

        public int Id { get => _id; set => _id = value; }
        public string Comentarios { get => _comentarios; set => _comentarios = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }

        public override string ToString()
        {
            return ($"Id: {this.Id}, Comentarios: {this.Comentarios}, Id Usuario: {this.IdUsuario}");
        }
    }
}
