using System.Data.SqlClient;

namespace Clase9ConsultaDatosADO_NET_actividadEnClaseForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            string connectionString = "Server=.;Database=coderhouse;Trusted_Connection=true;";

            var query = "SELECT * FROM Usuario";

          using (SqlConnection connection = new SqlConnection(connectionString)){
                
                connection.Open();

                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    using(SqlDataReader dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                var usuario = new Usuario();
                                usuario.Id = Convert.ToInt32(dataReader["Id"]);
                                usuario.Nombre = dataReader["Nombre"].ToString();
                                usuario.Apellido = dataReader["Apellido"].ToString();
                                usuario.NombreUsuario = dataReader["NombreUsuario"].ToString();
                                usuario.Password = dataReader["Contraseña"].ToString();
                                usuario.Email = dataReader["Mail"].ToString();
                                listaUsuarios.Add(usuario);

                            }
                        }
                    }
                }

            }
           dgvUsuarios.DataSource = listaUsuarios;
            dgvUsuarios.AutoGenerateColumns = true;
        }
    }
}
