using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        InsertProduct("Test Product", 1, 1, 25);
    }

    static void InsertProduct(string productName, int supplierId, int categoryId, decimal unitPrice)
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";

        string query = @"INSERT INTO Products (ProductName, SupplierID, CategoryID, UnitPrice)
                         VALUES (@ProductName, @SupplierID, @CategoryID, @UnitPrice)";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add parameters
                command.Parameters.AddWithValue("@ProductName", productName);
                command.Parameters.AddWithValue("@SupplierID", supplierId);
                command.Parameters.AddWithValue("@CategoryID", categoryId);
                command.Parameters.AddWithValue("@UnitPrice", unitPrice);

                // Open connection
                connection.Open();

                // Execute the insert command
                int rowsAffected = command.ExecuteNonQuery();

                // Feedback
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Product inserted successfully.");
                }
                else
                {
                    Console.WriteLine("Insert failed.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}