using LoginProject.Models;
using Microsoft.Data.SqlClient;

namespace LoginProject.Services
{
    public class UsersDAO
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public bool FindUserByNameAndPassword(UserModel user)
        {
            bool success = false;
            string SqlStatement = "SELECT * FROM dbo.Users WHERE USERNAME = @USERNAME AND PASSWORD = @PASSWORD";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(SqlStatement, connection);

                command.Parameters.Add("@USERNAME", System.Data.SqlDbType.VarChar, 50).Value = user.UserName;
                command.Parameters.Add("@PASSWORD", System.Data.SqlDbType.VarChar, 50).Value = user.password;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if(reader.HasRows){
                        success = true;
                    }
                } catch(Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }

                return success;
            }
        }
    }
}
