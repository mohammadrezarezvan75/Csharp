using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyContacts
{
    class ContactRepository : IContactRepository
    {
        private string Connectionstring = "Data Source=MRRZR7578\\MYSQL;Initial Catalog=Contact_DB;Trusted_Connection=True";
        public DataTable SelectAll()
        {
            string query = "Select * From MyContact";
            SqlConnection Connection = new SqlConnection(Connectionstring);
            SqlDataAdapter Adapter = new SqlDataAdapter(query, Connection);
            DataTable data = new DataTable();
            Adapter.Fill(data);
            return data;
        }

        public DataTable SelectRow(int ContactID)
        {

            string query = "Select * From MyContact where ContactId=" + ContactID;
            SqlConnection Connection = new SqlConnection(Connectionstring);
            SqlDataAdapter Adapter = new SqlDataAdapter(query, Connection);
            DataTable data = new DataTable();
            Adapter.Fill(data);
            return data;
        }

        public bool Insert(string Name, string Family, int Age, string Mobile, string Email, string Address)
        {
            SqlConnection connection = new SqlConnection(Connectionstring);
            try
            {
                string Query = "Insert Into MyContact (Name,Family,Age,Email,Mobile,Address) values (@Name,@Family,@Age,@Email,@Mobile,@Address)";
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Family", Family);
                command.Parameters.AddWithValue("@Age", Age);
                command.Parameters.AddWithValue("@Mobile", Mobile);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Address", Address);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

        }

        public bool Update(int ContactID, string Name, string Family, int Age, string Mobile, string Email, string Address)
        {
            SqlConnection connection = new SqlConnection(Connectionstring);
            try
            {
                string Query = "Update  MyContact set Name=@Name,Family=@Family,Age=@Age,Mobile=@Mobile,Email=@Email,Address=@Address where ContactID=@ID";
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@ID", ContactID);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Family", Family);
                command.Parameters.AddWithValue("@Age", Age);
                command.Parameters.AddWithValue("@Mobile", Mobile);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Address", Address);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

        }

        public bool Delete(int ContactID)
        {
            SqlConnection connection = new SqlConnection(Connectionstring);
            try
            {
                string Query = "Delete From MyContact where ContactID=@ID";
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@ID", ContactID);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }


        public DataTable Search(string parameter)
        {
            string query = "Select * From MyContact where Name like @parameter or Family like @parameter";
            SqlConnection Connection = new SqlConnection(Connectionstring);
            SqlDataAdapter Adapter = new SqlDataAdapter(query, Connection);
            DataTable data = new DataTable();
            Adapter.SelectCommand.Parameters.AddWithValue("parameter", "%" + parameter + "%");
            Adapter.Fill(data);
            return data;
        }
    }
}
