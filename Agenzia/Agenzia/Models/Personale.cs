using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Agenzia.Models
{
    public class Personale
    {
        public int Id { get; set; }
        public string Username { get; set;}
        public string Password { get; set;}
        public string Ruolo { get; set;}
        public static bool Autenticato(string username, string password)
        {
            SqlConnection con = SharedClass.GetConnectionDb();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("Select * from Personale where Username=@username and password=@password", con);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}