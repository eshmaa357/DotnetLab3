// 2) Write a program to select employees whose salary is greater than 50000 and whose 
//address is Kathmandu using LINQ. 

using System;
using System.Collections.Generic;
using System.Linq;

namespace EmpSelectEg
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
    }
    class Program
    {
        /*
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee> { 
            new Employee {Name = "Ishma" , Salary = 51000 , Address = "Ktm"},
            new Employee {Name = "Rita" , Salary = 65000 , Address = "Ktm"},
            new Employee {Name = "Gaurav" , Salary = 55000 , Address = "Gorkha" },
            new Employee {Name = "Samu" ,Salary = 20000, Address = "Ktm"},
            new Employee {Name = "Suman" , Salary = 80000 , Address = "Ktm"}
            
            };

            //using LINQ
            var selectedEmp = employee
                .Where(e => e.Salary > 50000 && e.Address == "Ktm")
                .ToList();
            //displaying
            Console.WriteLine("Employees whose salary is more than 50000 and address is 'Ktm' :");
            foreach(var empl in selectedEmp)
            {
                Console.WriteLine($"Name : {empl.Name} , Salary:{empl.Salary} , Address:{empl.Address}");
            }
            Console.ReadLine();
        }
        */
    }
}