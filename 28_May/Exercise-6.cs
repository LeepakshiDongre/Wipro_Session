using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        DisplayOrdersWithCustomerNames();
    }

    static void DisplayOrdersWithCustomerNames()
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";

        string query = @"
            SELECT o.OrderID, c.CompanyName, o.OrderDate
            FROM Orders o
            INNER JOIN Customers c ON o.CustomerID = c.CustomerID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                Console.WriteLine("OrderID\t\tCompanyName\t\t\tOrderDate");
                Console.WriteLine("------------------------------------------------------------");

                while (reader.Read())
                {
                    int orderId = (int)reader["OrderID"];
                    string companyName = reader["CompanyName"].ToString();
                    DateTime orderDate = (DateTime)reader["OrderDate"];

                    Console.WriteLine($"{orderId}\t\t{companyName,-30}\t{orderDate.ToShortDateString()}");
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