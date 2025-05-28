using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        InsertOrderWithDetails();
    }

    static void InsertOrderWithDetails()
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();

            try
            {
                // 1. Insert into Orders table
                string insertOrderQuery = @"
                    INSERT INTO Orders (CustomerID, OrderDate, ShipCountry)
                    VALUES (@CustomerID, @OrderDate, @ShipCountry);
                    SELECT SCOPE_IDENTITY();";

                SqlCommand insertOrderCmd = new SqlCommand(insertOrderQuery, connection, transaction);
                insertOrderCmd.Parameters.AddWithValue("@CustomerID", "ALFKI");
                insertOrderCmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                insertOrderCmd.Parameters.AddWithValue("@ShipCountry", "Germany");

                // Get the newly inserted OrderID
                int orderId = Convert.ToInt32(insertOrderCmd.ExecuteScalar());

                // 2. Insert into Order Details table
                string insertDetailQuery = @"
                    INSERT INTO [Order Details] (OrderID, ProductID, UnitPrice, Quantity, Discount)
                    VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount);";

                SqlCommand insertDetailCmd = new SqlCommand(insertDetailQuery, connection, transaction);
                insertDetailCmd.Parameters.AddWithValue("@OrderID", orderId);
                insertDetailCmd.Parameters.AddWithValue("@ProductID", 1); // Example: Chai
                insertDetailCmd.Parameters.AddWithValue("@UnitPrice", 18.00m);
                insertDetailCmd.Parameters.AddWithValue("@Quantity", 10);
                insertDetailCmd.Parameters.AddWithValue("@Discount", 0);

                insertDetailCmd.ExecuteNonQuery();

                // 3. Commit transaction if both succeed
                transaction.Commit();
                Console.WriteLine("Transaction committed. Order and details inserted successfully.");
            }
            catch (Exception ex)
            {
                // 4. Rollback on error
                transaction.Rollback();
                Console.WriteLine("Transaction rolled back. Error: " + ex.Message);
            }
        }
    }
}