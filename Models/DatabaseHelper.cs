using System.Data;
using System.Data.SqlClient;

namespace LoginUsers.Models
{
    public class DatabaseHelper
    {

        private readonly string connectionString;

        public DatabaseHelper()
        {
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PersonDatabase;Integrated Security=True";
        }

        public void InsertPerson(int id, string firstName, string lastName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("InsertPerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@Id", id)); 
                    command.Parameters.Add(new SqlParameter("@FirstName", firstName));
                    command.Parameters.Add(new SqlParameter("@LastName", lastName));

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}