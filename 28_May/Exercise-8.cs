using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        Console.Write("Enter Customer ID (e.g., ALFKI): ");
        string customerId = Console.ReadLine();

        GetCustomerOrderHistory(customerId);
    }

    static void GetCustomerOrderHistory(string customerId)
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("CustOrderHist", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add the input parameter
                command.Parameters.AddWithValue("@CustomerID", customerId);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                Console.WriteLine("Product Name\t\tTotal");
                Console.WriteLine("----------------------------------------");

                while (reader.Read())
                {
                    string productName = reader["ProductName"].ToString();
                    int total = Convert.ToInt32(reader["Total"]);

                    Console.WriteLine($"{productName,-25} {total}");
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