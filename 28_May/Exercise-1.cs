using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
   
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";
        string query = "SELECT CustomerID, CompanyName, Country FROM Customers";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine("CustomerID\tCompanyNmae\t\t\tCountry");
                Console.WriteLine("---------------------------------------------------------------");
                 while (reader.Read())
                 {
                        string customerId = reader["CustomerID"].ToString();
                        string companyName = reader["CompanyName"].ToString();
                        string country = reader["Country"].ToString();

                        Console.WriteLine($"{customerId}\t\t{companyName,-30}\t{country}");
                 }
                    reader.Close();
                
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}