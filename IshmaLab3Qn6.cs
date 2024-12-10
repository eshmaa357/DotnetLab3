// 6) Write a C# program to define custom exception

using System;

namespace CustomExceptionExample
{
    // Custom exception class
    public class AgeException : Exception
    {
        // Default constructor
        public AgeException() : base("Age cannot be less than 18.") { }

        // Constructor that accepts a custom message
        public AgeException(string message) : base(message) { }

        // Constructor that accepts a custom message and an inner exception
        public AgeException(string message, Exception innerException)
            : base(message, innerException) { }
    }

    class Program
    {
        /*
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your age:");
                int age = Convert.ToInt32(Console.ReadLine());

                // Throw custom exception if age is less than 18
                if (age < 18)
                {
                    throw new AgeException("You must be at least 18 years old to proceed.");
                }

                Console.WriteLine("You entered a valid age: " + age);
            }
            catch (AgeException ex)
            {
                // Catch the custom exception and display its message
                Console.WriteLine("Custom Exception caught: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Catch any other general exceptions
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        */
    }
}
