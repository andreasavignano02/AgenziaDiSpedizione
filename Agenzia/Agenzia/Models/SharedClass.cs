using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace Agenzia.Models
{
    public class SharedClass
    {
        public static SqlConnection GetConnectionDb()
        {
            string con = ConfigurationManager.ConnectionStrings["AgenziaDB"].ToString();
            SqlConnection sql = new SqlConnection(con);
            return sql;
        }
        public static SqlDataReader GetReaderAfterSQL(string SQLCommandText, SqlConnection sqlConnection)
        {
            SqlCommand sqlCommand = new SqlCommand(SQLCommandText, sqlConnection);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            return reader;
        }
    }
}