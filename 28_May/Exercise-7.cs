using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        DisplayTotalSalesByCategory();
    }

    static void DisplayTotalSalesByCategory()
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";

        string query = @"
            SELECT p.CategoryID, SUM(od.UnitPrice * od.Quantity) AS TotalSales
            FROM [Order Details] od
            INNER JOIN Products p ON od.ProductID = p.ProductID
            GROUP BY p.CategoryID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                Console.WriteLine("CategoryID\tTotalSales");
                Console.WriteLine("------------------------------");

                foreach (DataRow row in dataTable.Rows)
                {
                    int categoryId = Convert.ToInt32(row["CategoryID"]);
                    decimal totalSales = Convert.ToDecimal(row["TotalSales"]);

                    Console.WriteLine($"{categoryId}\t\t{totalSales:C}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}