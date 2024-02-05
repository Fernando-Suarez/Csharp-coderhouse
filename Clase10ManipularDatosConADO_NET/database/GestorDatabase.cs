using Clase10ManipularDatosConADO_NET.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10ManipularDatosConADO_NET.database
{
    public class GestorDatabase

    {
        private string connectionString;

        public GestorDatabase()
        {
            connectionString = "Server=.;Database=coderhouse;Trusted_Connection=true;";
        }

        public Usuario GetUserById(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString)) 
            { 
                string query = "SELECT * FROM Usuario WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection); 
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                

                SqlDataReader reader = command.ExecuteReader();
                    
                        if (reader.Read())
                        {
                            int userId = Convert.ToInt32(reader[0]);
                            string nombre = reader.GetString(1);
                            string apellido = reader.GetString(2);
                            string nombreUsuario = reader.GetString(3);
                            string password = reader.GetString(4);
                            string email = reader.GetString(5);

                            Usuario usuario = new Usuario(userId,nombre,apellido,nombreUsuario,password,email);
                            return usuario;

                        }
                        throw new Exception("Id no encontrado");                  
            }
        }

        public bool CreateUser(Usuario usuario)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "INSERT INTO Usuario(nombre,apellido,nombreUsuario,contraseña,mail) values(@nombre , @apellido, @nombreUsuario, @password, @email)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("nombre", usuario.Nombre);
                command.Parameters.AddWithValue("apellido", usuario.Apellido);
                command.Parameters.AddWithValue("nombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("password", usuario.Password);
                command.Parameters.AddWithValue("email", usuario.Email);
                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteUser(int id)
        {
            using(SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "DELETE FROM Usuario WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("id", id); 
                
                return command.ExecuteNonQuery() > 0;
            }
        }


        public bool UpdateUser(int id, Usuario usuario)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "UPDATE Usuario SET nombre = @nombre,apellido = @apellido, nombreUsuario = @nombreUsuario,contraseña = @password ,mail = @email WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("nombre", usuario.Nombre);
                command.Parameters.AddWithValue("apellido", usuario.Apellido);
                command.Parameters.AddWithValue("nombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("password", usuario.Password);
                command.Parameters.AddWithValue("email", usuario.Email);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateUser(int id, string nombreUsuario)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "UPDATE Usuario SET nombreUsuario = @nombreUsuario WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("nombreUsuario", nombreUsuario );
               ;

                return command.ExecuteNonQuery() > 0;
            }
        }


    }
}
