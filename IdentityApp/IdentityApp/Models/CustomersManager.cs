using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityApp.Models
{
    public class CustomersManager
    {
        SqlConnection connection = new SqlConnection ("Data Source=.;Initial Catalog=aspnet-deneme2-28EBA202-9EDE-454C-97FB-2C13A102F128;User ID=sa;Password=<Sifreniz>");
        public List<AspNetCustomers> ReadCustomer ()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From AspNetCustomers", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<AspNetCustomers> add = new List<AspNetCustomers>();
            while (reader.Read())
            {
                
                AspNetCustomers x = new AspNetCustomers();
                x.Id = reader["Id"].ToString();
                x.Explanation = reader["Explanation"].ToString();
                x.Data = reader["Data"].ToString();
                x.Name = reader["Name"].ToString();
                x.Image = reader["Image"].ToString();
                add.Add(x);
                
            }
            connection.Close();
            return add;
        }
        public int AddCustomer (AspNetCustomers Customer)
        {
            AspNetKeys key = new AspNetKeys();
            KeyManager keyManager = new KeyManager();
            string id;
            while(true)
            {
                id = RijndaelEncryption.GenerateSecureKey();
                if(id.IndexOf('/')==-1)
                {
                    break;
                }
            }
            key.aesKey = RijndaelEncryption.GenerateSecureKey();
            key.Id = id;
            Customer.Id = id;
            keyManager.AddKey(key);
            string encryptedData = RijndaelEncryption.Encrypt(key.aesKey, Customer.Data);
            Customer.Data = encryptedData;
            connection.Open();
            SqlCommand command = new SqlCommand("insert into AspNetCustomers(Id,Explanation , Data , Name , Image) Values('"+Customer.Id+"','"+Customer.Explanation+"','"+Customer.Data+"','"+Customer.Name+"','"+Customer.Image+"')",connection);
            command.ExecuteNonQuery();
            connection.Close();
            int x = 1;
            return x;
        }

        public void DeleteCustomer (string id)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Delete From AspNetCustomers Where Id=('"+id+"')",connection);
            SqlCommand command2 = new SqlCommand("Delete From AspNetKeys Where Id=('" + id + "')", connection);
            command2.ExecuteNonQuery();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public AspNetCustomers FindCustomer(string id)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From AspNetCustomers Where Id=('"+id+"')", connection);
            SqlDataReader reader = command.ExecuteReader();
            AspNetCustomers x = new AspNetCustomers();
            reader.Read();
            x.Id = id;
            x.Name = reader["Name"].ToString();
            x.Explanation = reader["Explanation"].ToString();
            x.Data = reader["Data"].ToString();
            reader.Close();
            SqlCommand command2 = new SqlCommand("Select aesKey From AspNetKeys Where Id=('"+id+"')", connection);
            reader = command2.ExecuteReader();
            reader.Read();
            string temp = RijndaelEncryption.Decrypt(reader["aesKey"].ToString(), x.Data);
            x.Data = temp;
            connection.Close();
            return x;
        }
        public int UpdateCustomer(AspNetCustomers customer)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select aesKey From AspNetKeys Where Id=('"+customer.Id+"')", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            customer.Data = RijndaelEncryption.Encrypt(reader["aesKey"].ToString(), customer.Data);
            reader.Close();
            SqlCommand command2 = new SqlCommand("UPDATE AspNetCustomers SET Data=('" + customer.Data + "'),Explanation=('" + customer.Explanation + "'),Name=('" + customer.Name + "') Where id=('"+customer.Id+"')",connection);
            command2.ExecuteNonQuery();
            connection.Close();
            return 1;
        }
            
    }
}
