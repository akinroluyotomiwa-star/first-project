using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project.Statements
{
    public class IfStatement
    {
        public IfStatement()
        {
            Console.WriteLine("Enter your age");

            int age = Convert.ToInt32(Console.ReadLine());
            //if else statement
            if (age >= 17)
                Console.WriteLine("You can vote.");

            else if (age == 16)
                Console.WriteLine("You have a year left to be eligible");
            else
                Console.WriteLine("You are to young to vote.");
        }
    }
}
