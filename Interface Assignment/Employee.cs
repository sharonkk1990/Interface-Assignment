

using System;

namespace Interface_Assignment
{
    // Employee inherits Person and implements IQuittable
    public class Employee : Person, IQuittable
    {
        // Employee ID
        public int Id { get; set; }

        // Implement SayName method
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        // Implement Quit method
        public void Quit()
        {
            Console.WriteLine(firstName + " " + lastName + " has quit the company.");
        }
    }
}