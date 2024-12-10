//5) Write a C# program to demonstrate exception. 

using System;
namespace ExceptionHandlingEg
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number :");
                int number = int.Parse(Console.ReadLine());

                CheckPositiveNumber(number);

                Console.Write("Enter a divisor :");
                int divisor = int.Parse(Console.ReadLine());

                int result = DivideNumbers(number, divisor);
                Console.WriteLine($"Result of division : {result}");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("FormatException Caught: Please enter a valid number.");
                Console.WriteLine($"Details: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException Caught: Cannot divide by zero.");
                Console.WriteLine($"Details: {ex.Message}");
            }
            catch (InvalidNumberException ex)
            {
                Console.WriteLine("Custom Exception Caught: " + ex.Message);
            }
            catch (Exception ex)
            {
                // General exception handler for any other exceptions.
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                // This block will always execute, even if an exception is thrown.
                Console.WriteLine("Program has finished executing.");
            }
        }

        // Method that throws a custom exception if the number is not positive.
        static void CheckPositiveNumber(int number)
        {
            if (number <= 0)
            {
                throw new InvalidNumberException("The number must be greater than zero.");
            }
        }

        // Method that divides two numbers and demonstrates exception handling.
        static int DivideNumbers(int numerator, int divisor)
        {
            // This will throw a DivideByZeroException if divisor is zero.
            return numerator / divisor;
        }
    }

    // Custom exception class.
    public class InvalidNumberException : Exception
    {
        public InvalidNumberException(string message) : base(message)
        {
        Console.ReadLine();
        }
        */
    }
    }
