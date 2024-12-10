// 4. Write a C# program to show edit and delete operation in database

using System;
using MySql.Data.MySqlClient;

namespace IshmaLab3Qn4 {
    class IshmaLab3Qnn4
    {
        /*
        static void Main(string[] args)
        {
            // Connection string to the MySQL database
            string connectionString = "Server=localhost;Database=testdb;User=root;Password=;";

            // Edit operation: Update age of a person
            EditData(connectionString, "Shiva Rai", 30); // Update Shiva Rai's age to 30

            // Delete operation: Delete a person by name
            DeleteData(connectionString, "Rita Lamsal"); // Delete Rita Lamsal from the database

            // Select operation to show the final state of the table
            SelectData(connectionString);
        }

        // Edit operation: Update data in the database
        static void EditData(string connectionString, string name, int newAge)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL query to update the age of a person based on name
                    string query = "UPDATE Persons SET Age = @Age WHERE Name = @Name";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Age", newAge);
                        command.Parameters.AddWithValue("@Name", name);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Successfully updated {name}'s age to {newAge}.");
                        }
                        else
                        {
                            Console.WriteLine($"No person found with the name {name}.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        // Delete operation: Remove a person from the database
        static void DeleteData(string connectionString, string name)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL query to delete a person by name
                    string query = "DELETE FROM Persons WHERE Name = @Name";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Successfully deleted {name} from the database.");
                        }
                        else
                        {
                            Console.WriteLine($"No person found with the name {name}.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        // Select operation: Display all records in the Persons table
        static void SelectData(string connectionString)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL query to select all records from the Persons table
                    string query = "SELECT Id, Name, Age FROM Persons";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Print the headers for the data
                            Console.WriteLine("Id\tName\t\tAge");

                            // Read and display each row of data
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader["Id"]}\t{reader["Name"]}\t\t{reader["Age"]}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                */
            }
        }
