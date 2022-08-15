using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityApp.Models
{
    public class KeyManager
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=aspnet-deneme2-28EBA202-9EDE-454C-97FB-2C13A102F128;User ID=sa;Password=<Sifreniz>");
        public void AddKey(AspNetKeys key)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into AspNetKeys(Id,aesKey) Values('" + key.Id + "','" + key.aesKey + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();

        }

        public string FindKey(int Id)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From AspNetKeys Where Id=(" + Id + ")", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string regularKey = reader["aesKey"].ToString();
            connection.Close();
            return regularKey;
        }
    }
}
