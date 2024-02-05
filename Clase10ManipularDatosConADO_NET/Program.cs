using Clase10ManipularDatosConADO_NET.database;
using Clase10ManipularDatosConADO_NET.models;
using System.Data.SqlClient;

namespace Clase10ManipularDatosConADO_NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestorDatabase db = new GestorDatabase();

            try
            {
                //Usuario userById = db.GetUserById(1);
                //Console.Write(userById.ToString());

                Usuario newUser = new Usuario( "Carlos", "Villegas", "carli", "123", "mail@mail");
                if (db.CreateUser(newUser))
                {
                    Console.WriteLine("Usuario agregado con exito");
                }

                //if(db.DeleteUser(3))
                //{
                //    Console.WriteLine("Usuario Eliminado con Exito");
                //}


                //if (db.UpdateUser(4, "pedroElMejor"))
                //{
                //    Console.WriteLine("Usuario Actualizado con exito");
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
