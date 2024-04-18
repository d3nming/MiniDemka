using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bib.Models
{
    internal class Bd
    {
        string conn = "Data Source = localhost; Integrated Security = SSPI; Initial Catalog = ActivityConference;";
        public SqlConnection Connection()
        {
            SqlConnection connection = new SqlConnection(conn);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
    }
}
