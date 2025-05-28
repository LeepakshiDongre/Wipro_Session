using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        Console.Write("Enter Product ID to delete: ");
        if (int.TryParse(Console.ReadLine(), out int productId))
        {
            DeleteProduct(productId);
        }
        else
        {
            Console.WriteLine("Invalid Product ID.");
        }
    }

    static void DeleteProduct(int productId)
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";

        string query = "DELETE FROM Products WHERE ProductID = @ProductID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Bind parameter
                command.Parameters.AddWithValue("@ProductID", productId);

                connection.Open();

                // Execute deletion
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Product deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Product not found or already deleted.");
                }
            }
        }
        catch (SqlException ex)
        {
            // Handles foreign key or other SQL-related issues
            Console.WriteLine("SQL Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("General Error: " + ex.Message);
        }
    }
}