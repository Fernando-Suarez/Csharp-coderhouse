using System.Data.SqlClient;


namespace Clase9ConsultaDatosADO_NET_actividadEnClaseForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Producto> listaProductos = new List<Producto>();

            string connectionString = @"Server=.;Database=coderhouse;Trusted_Connection=True;";
            var query = "SELECT Id,Descripciones,Costo,PrecioVenta,Categoria FROM Producto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               
                    connection.Open(); 
               
               
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                   
                    

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while(dataReader.Read())
                            {
                                var producto = new Producto();
                                producto.Id = Convert.ToInt32(dataReader["Id"]);
                                producto.Descripcion = dataReader["Descripciones"].ToString();
                                producto.Costo = Convert.ToDouble(dataReader["Costo"]);
                                producto.PrecioVenta = Convert.ToDouble(dataReader["PrecioVenta"]);
                                producto.Categoria = dataReader["Categoria"].ToString();
                                listaProductos.Add(producto);

                            }
                        }

                    }


                }
            }
            dgvLista.DataSource = listaProductos;
            dgvLista.AutoGenerateColumns = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
