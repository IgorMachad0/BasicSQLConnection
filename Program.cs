using System.Data.SqlClient;
using System;


try
{
    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(
        "User Id=sa;Password=1234;" +
        "Database=testProject;" +
        "Server=localhost\\SQLEXPRESS;" +        
        "Trusted_Connection=False;"
    );

    using (SqlConnection Connect = new SqlConnection(builder.ConnectionString))
    {

        string sql = "Select * from customers";

        using (SqlCommand Command = new SqlCommand(sql, Connect))
        {

            Connect.Open();
            using (SqlDataReader Reader = Command.ExecuteReader())
            {

                while (Reader.Read())
                {

                    System.Console.WriteLine("id: {0} ", Reader[0]);
                }
            }
        }
    }

}
catch (System.Exception)
{

    throw;
}
