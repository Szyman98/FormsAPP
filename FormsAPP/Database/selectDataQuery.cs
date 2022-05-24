using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ZadanieRekrutacyjne.Database
{
    public class selectDataQuery
    {
        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-OGSKMHK\naukasql;Initial Catalog=Zadanie;Integrated Security=True");
        public DataTable GetRaport(string Lokal, string fromDate, string toDate)
        {
            DataTable dt = new DataTable();

            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }
                string query = "SELECT [Nazwa],[Data],[Godzina],[Użytkownik],[Lokal] FROM [Zadanie].[dbo].[Raport] where Lokal = @lokal and Data between @fromDate and @toDate ";
                SqlCommand sqlcmd1 = new SqlCommand(query, _connection);
                sqlcmd1.CommandType = CommandType.Text;
               sqlcmd1.Parameters.AddWithValue("@lokal", Lokal);
               sqlcmd1.Parameters.AddWithValue("@fromDate", fromDate);
               sqlcmd1.Parameters.AddWithValue("@toDate", toDate);

                SqlDataReader reader = sqlcmd1.ExecuteReader();

                dt.Load(reader);

                

             


                return dt;
            }
            catch
            {
                return null;
            }
        }
    }
}
