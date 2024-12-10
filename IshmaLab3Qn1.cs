//1) Write a C# program to demonstrate example of multicast delegate. 

using System;
namespace IshmaLab3Qn1
{
    // Declare a delegate that takes no parameters and returns void.
    public delegate void MyDelegate();

    class Program
    {
        // Method 1: To be assigned to the delegate.
        public static void Method1()
        {
            Console.WriteLine("Method1 is called");
        }
        // Method 2: To be assigned to the delegate.
        public static void Method2()
        {
            Console.WriteLine("Method2 is called");
        }
        // Method 3: To be assigned to the delegate.
        public static void Method3()
        {
            Console.WriteLine("Method3 is called");
        }
        /*
        static void Main(string[] args)
        {
            // Create delegate instances pointing to the methods.
            MyDelegate del = Method1;
            del += Method2;  // Adding Method2 to the delegate.
            del += Method3;  // Adding Method3 to the delegate.
            Console.WriteLine("Invoking the multicast delegate:");
            del();  // Invoking the delegate, which will call all three methods.
            // Removing Method2 from the delegate.
            del -= Method2;
            Console.WriteLine("\nAfter removing Method2:");
            del();  // Invoking the delegate, which will call Method1 and Method3.
            Console.ReadLine();
        }
        */
    }
}
