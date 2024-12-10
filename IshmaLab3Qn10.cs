// 10) Write a C# program to save a tourism information in database. Assume you have a table
// ‘Tour Destination’ with columns Id, title, description, duration and CreatedDate.

using System;
using MySql.Data.MySqlClient;

class IshmaLab3Qn10
{
    // Update with your database connection string
    static string connectionString = "Server=localhost;Database=Tourisminfo;User=root;Password=;";

    static void InsertData(string title, string description, int duration, DateTime createdDate)
    {
        string query = "INSERT INTO TourDestination (Title, Description, Duration, CreatedDate) VALUES (@Title, @Description, @Duration, @CreatedDate)";

        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Title", title);
            command.Parameters.AddWithValue("@Description", description);
            command.Parameters.AddWithValue("@Duration", duration);
            command.Parameters.AddWithValue("@CreatedDate", createdDate);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) inserted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

    static void ReadData()
    {
        string query = "SELECT Id, Title, Description, Duration, CreatedDate FROM TourDestination";

        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                Console.WriteLine("Id\tTitle\t\t\tDescription\t\t\t\t\t\tDuration\tCreatedDate");
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["Id"]}\t{reader["Title"]}\t{reader["Description"]}\t{reader["Duration"]}\t{reader["CreatedDate"]}");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
    /*
    static void Main()
    {
        // Insert data into the database
        Console.WriteLine("Inserting data:");
        InsertData("Everest Base Camp Trek", "A scenic trek to the base of the world's highest peak.", 14, DateTime.Now);
        InsertData("Chitwan Jungle Safari", "Experience wildlife and natural beauty in Chitwan NP.", 7, DateTime.Now);

        // Display the data
        Console.WriteLine("\nDisplaying data:");
        ReadData();

        Console.ReadKey();
    }
}
*/