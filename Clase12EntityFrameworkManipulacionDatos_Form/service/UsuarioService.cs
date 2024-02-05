using Clase12EntityFrameworkManipulacionDatos_Form.database;
using Clase12EntityFrameworkManipulacionDatos_Form.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clase12EntityFrameworkManipulacionDatos_Form.service
{
    public static class UsuarioService
    {
        public static List<Usuario> ObtenerUsuarios()
        {
            
            using (CoderContext context = new CoderContext())
            {
                List<Usuario> usuarios = context.Usuarios.ToList();
                return usuarios;
            }
        }

        public static List<Usuario> ObtenerUsuario(int id)
        {
            
            using (CoderContext context = new CoderContext())
            {
                 ;
                List<Usuario> lista = new List<Usuario>();
                Usuario? UsuarioId = context.Usuarios.Where((usuario) => usuario.Id  == id).FirstOrDefault();
                lista.Add(UsuarioId);
                return lista;

            }
        }

        public static bool CrearUsuario(Usuario usuario)
        {
            using (CoderContext context = new CoderContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
                return true;
            }
        }

        public static bool ModificarUsuario(Usuario usuario, int id)
        {
            using(CoderContext context = new CoderContext())
            {
                Usuario? usuarioId = context.Usuarios.Where((usuario) => usuario.Id == id).FirstOrDefault();
                usuarioId.Nombre = usuario.Nombre;
                usuarioId.Apellido = usuario.Apellido;
                usuarioId.NombreUsuario = usuario.NombreUsuario;
                usuarioId.Mail = usuario.Mail;

                context.Usuarios.Update(usuarioId);
                context.SaveChanges();
                return true;
            }
        }

        public static bool EliminarUsuario(int id)
        {
            using (CoderContext context = new CoderContext())
            {
                Usuario? usuario = context.Usuarios.Where((u) => u.Id == id).FirstOrDefault();
                context.Remove(usuario);
                context.SaveChanges();
                return true;
            }
        }
    }
}
