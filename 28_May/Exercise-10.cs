using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        LoadProductsAndDisplayAvailableStock();
    }

    static void LoadProductsAndDisplayAvailableStock()
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";

        string query = "SELECT ProductID, ProductName, UnitsInStock FROM Products";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Products");

                DataTable productsTable = dataSet.Tables["Products"];

                Console.WriteLine("Products with more than 20 units in stock:");
                Console.WriteLine("ProductID\tProductName\t\tUnitsInStock");
                Console.WriteLine("---------------------------------------------------");

                foreach (DataRow row in productsTable.Rows)
                {
                    int unitsInStock = Convert.ToInt32(row["UnitsInStock"]);
                    if (unitsInStock > 20)
                    {
                        int productId = Convert.ToInt32(row["ProductID"]);
                        string productName = row["ProductName"].ToString();

                        Console.WriteLine($"{productId}\t\t{productName,-20}\t{unitsInStock}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}