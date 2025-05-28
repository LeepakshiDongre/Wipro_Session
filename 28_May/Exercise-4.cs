using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        Console.Write("Enter Employee ID to update: ");
        int employeeId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter new Title: ");
        string newTitle = Console.ReadLine();

        UpdateEmployeeTitle(employeeId, newTitle);
    }

    static void UpdateEmployeeTitle(int employeeId, string newTitle)
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";

        string query = "UPDATE Employees SET Title = @Title WHERE EmployeeID = @EmployeeID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Bind parameters
                command.Parameters.AddWithValue("@Title", newTitle);
                command.Parameters.AddWithValue("@EmployeeID", employeeId);

                // Open connection
                connection.Open();

                // Execute update
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Employee title updated successfully.");
                }
                else
                {
                    Console.WriteLine("Employee not found or no change made.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}