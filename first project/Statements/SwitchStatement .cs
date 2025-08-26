using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project.Statements
{
    internal class SwitchStatement
    {
        public SwitchStatement() 
        {
            Console.WriteLine("Enter your age");

            int age = Convert.ToInt32(Console.ReadLine());

            switch (age)
            {
                case 17:
                    Console.WriteLine("You can vote.");
                    break;
                case 16:
                    Console.WriteLine("You have a year left to be eligible");
                    break;
                case 15:
                    Console.WriteLine("You have two year left to be eligible");
                    break;
                case 14:
                    Console.WriteLine("You have a year left to be eligible");
                    break;
                default:
                    Console.WriteLine("You are to young to vote.");
                    break;
            }
        }
    }
}
