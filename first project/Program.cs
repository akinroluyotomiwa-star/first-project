using System;
using System.ComponentModel.Design;
using System.Diagnostics;
internal class Program
{
    private static void Main(string[] args)
    {
        //syntax
        //for(initialisation; condition; iteration)
        //{
        //    //block of code to be executed
        //}

        //for (int i = 5; i <= 10; i++)
        //{
        //    Console.WriteLine(i);
        //}
        //Create a calculator app that adds two numbers.
        //Console.WriteLine("Enter num1");
        //int num1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter num2");
        //int num2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter operator(-,+,*,/)");
        //string operators = Console.ReadLine();
        //if (operators == "-")
        //    Console.WriteLine(num1 + num2);
        //else if (operators == "+")
        //    Console.WriteLine(num1 + num2);
        //else if (operators == "*")
        //    Console.WriteLine(num1 * num2);
        //else if (operators == "/")
        //    Console.WriteLine(num1 / num2);
        //else
        //    Console.WriteLine("Invalid imput");

         string name = "John"; 
        int age = 10;
        string club = "Chelsea";
        string FavPlayer = "Vinni";

 Console.WriteLine("Hello " + name + age + club + FavPlayer + "this is all about" + name);  //Concatenation        
Console.WriteLine($"Hello {name} {age} {club} {FavPlayer} this is all about {name}");// Interpolation 
    }
}
       