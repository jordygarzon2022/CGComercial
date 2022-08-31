using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Windows.Forms;
using System.Reflection;

namespace CGComercial
{
    public class Connecting
    {
        SqlConnection Connect;
        SqlCommand Command;
        DataSet DataSet;
        SqlDataAdapter DataAdapter;
        DataTable dataTable;

        public void ConsultaDoc()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "<uniutserver.database.windows.net>";
                builder.UserID = "<adminserver>";
                builder.Password = "<admin2022*>";
                builder.InitialCatalog = "<CALZADO_GEEK_TIENDA>";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    String sql = $"SELECT * FROM CALZADO_GEEK_TIENDA.client_cg_person WHERE client_id_person = '{ObjectsDatabase.numeroDocumento}';";

                    


                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
         
    }
}
