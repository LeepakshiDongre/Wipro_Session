using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        Console.Write("Enter Customer ID: ");
        string inputCustomerId = Console.ReadLine();

        GetOrderByCustomer(inputCustomerId);
    }

    static void GetOrderByCustomer(string customerId)
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";
        string query = "SELECT OrderID, OrderDate, ShipCountry FROM Orders WHERE CustomerID = @customerId";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameter safely
                    command.Parameters.AddWithValue("@customerId", customerId);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    Console.WriteLine("\nOrders for Customer ID: " + customerId);
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("OrderID\t\tOrderDate\t\tShipCountry");

                    bool hasRows = false;
                    while (reader.Read())
                    {
                        hasRows = true;
                        int orderId = (int)reader["OrderID"];
                        DateTime orderDate = (DateTime)reader["OrderDate"];
                        string shipCountry = reader["ShipCountry"].ToString();

                        Console.WriteLine($"{orderId}\t\t{orderDate.ToShortDateString()}\t{shipCountry}");
                    }

                    if (!hasRows)
                    {
                        Console.WriteLine("No orders found for this Customer ID.");
                    }

                    reader.Close();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}