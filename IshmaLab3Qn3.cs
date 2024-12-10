//3) Write a C# program to show insert and select operation in database

using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

    namespace IshmaLab3Qn3 {

    class Program
    {
        /*
        static void Main(string[] args)
        {
            // Connection string to the MySQL database
            string connectionString = "Server=localhost;Database=testdb;User=root;Password=;";


            // Insert operation
            InsertData(connectionString, "Ishma Timsina", 21);
            InsertData(connectionString, "Rita Lamsal", 52);
            InsertData(connectionString, "Shiva Rai", 24);

            // Select operation
            SelectData(connectionString);
        }


        static void InsertData(string connectionString, string name, int age)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Persons (Name, Age) VALUES (@Name, @Age)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Age", age);

                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Inserted {rowsAffected} row(s) successfully.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        static void SelectData(string connectionString)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT Id, Name, Age FROM Persons";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            Console.WriteLine("Id\tName\t\tAge");
                            // Console.WriteLine("---------------------------");

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
            }
            Console.ReadLine();
        }
        */
    }
}
