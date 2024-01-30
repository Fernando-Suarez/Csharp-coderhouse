using System.Data.SqlClient;  // Agregamos el using de SqlClient

namespace Clase9ConsultaDatosADO_NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string connectionString = @"Server=.;Database=coderhouse;Trusted_Connection=True;";// con el @ al principio lo usamos como escape para que no tiere error las  \

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                    //Abro la conextion
                    connection.Open();
                //Creamos el comando a ejecutar
                using (SqlCommand comando = new SqlCommand("SELECT * FROM producto", connection))
                {

                    //Creo el DataReader y ejecuto el metodo ExecuteREader para recuperar los datos

                    using (SqlDataReader dataReader = comando.ExecuteReader())
                    {
                        // Me aseguro que haya filas disponibles
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                //Recupero el dato
                                var dato = dataReader.GetString(1);
                // Aca deberia trabajar o hacer algo con ese dato que recupere.
                            }
                        }
                    } 

                }
                connection.Close();

            }
        }
    }
}

// ---- DataAdapter

//defino el connecitonString
// string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=true;";

//creamos la conexion
// using (SqlConnection connection = new SqlConnection(connectionString))
// {
//  //creo el adaptador de datos con la query que voy a ejecutar
//   SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM usuarios",connection);

//Abro la conexion
//connection.Open();

//recupero el resultado y lo guardo en un dataSet
//DataSet resultado = new DataSet();
//adapter.Fill(resultado);

//cierro la conexion
//connection.Close();
// }
// ------------------------------