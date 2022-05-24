using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieRekrutacyjne.Database
{
    public class LokaleQuery
    {
        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-OGSKMHK\naukasql;Initial Catalog=Zadanie;Integrated Security=True");

        public List<string>GetLokaleList()
        {
            List<string> lokale = new List<string>();
            
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }
                string query = "SELECT DISTINCT Lokal FROM [Zadanie].[dbo].[Raport]";
                SqlCommand sqlcmd1 = new SqlCommand(query, _connection);
                SqlDataReader reader = sqlcmd1.ExecuteReader();
                
                while(reader.Read())
                {
                    lokale.Add(reader["Lokal"].ToString());
                }
                

                _connection.Close();
                return lokale;
            }
            catch
            {
                return null;
            }
        }

    }
}
