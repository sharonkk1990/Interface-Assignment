using System;

namespace Interface_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Employee object
            Employee employee = new Employee()
            {
                firstName = "Sample",
                lastName = "Student",
                Id = 1
            };

            // Display employee name
            employee.SayName();

            // Demonstrate polymorphism
            IQuittable quittableEmployee = employee;

            // Call the Quit method through the interface
            quittableEmployee.Quit();

            Console.ReadLine();
        }
    }
}