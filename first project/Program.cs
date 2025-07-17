using System.Net.Security;

public class Program //class
{
    //Introduction to c#
    //First c# Project(Hello world
    //Syntax
    //Ouput and comment
    //Data types and variables
    //Methods contains statement
    private static void Main(string[] args) // entry point
    {
        Console.WriteLine("hello tomiwa");
        Console.WriteLine("/////////////////////");
        Hello();
        Console.WriteLine("-------------------");
        hello();
        Console.WriteLine("///////////////////////");
        Tomiwa();
        Console.WriteLine("---------------------");

        //create an object from the players class
        Players players = new Players();
        //assigning values directly to public fields
        players.name = "Vini Junior";
        players.age = 26;
        players.month = "october";
        //call the method to print the details
        players.introducePlayer();
   }


    // A single line comment
    //Console.WriteLine -> print with a new line
    //Console.Write ->print without a new line
    /* This is a multi-line comment   */
     public static void Hello() //Methods contains statement
    {
        Console.Write("say Hello"); // output say HelloSAY HELLO
        Console.WriteLine("SAY HELLO");
        // output say HelloSAY HELLO
    }
    public static void hello()
    {
        //Console.WriteLine("say hello");
        Console.WriteLine(12 + 23); //      Output 35
        Console.WriteLine("12" + "23"); // output 1223
    }

    //Data Types and Variables
    //A variable stores data
    //A data type tells c# what kind of data a variable hold
    //Common Data Types String(Text), Int(Whole Numbers), Double(Decimal Numbers), Bool(true/false value)

    // String name = "Tomiwa";
    //Int age = 13
    //Double averageAge = 6.5
    //bool isAGoodBoy = true;
    public static void Tomiwa() //method
    {
        string name = "Tomiwa";
        int age = 13;
        Double averageAge = 6.5;
        bool isAGoodBoy = true;

        Console.WriteLine("Name: " + name); // Name: Tomiwa
        Console.WriteLine("Age: " + age); // Age: 13
        Console.WriteLine("AverageAge: " + averageAge); //AverageAge: 6.5
        Console.WriteLine("Is He A Good Boy: " + isAGoodBoy); // Is He A Good Boy: true
    }

    //Class
    //A class is like a blue print, it defines what an object can have(fields) and do(methods)
    //Classes contains fields , methods and properties
    class Players
    {
        //Fields
        public string name;
        public string month;
        public int age;

        //Method
        public void introducePlayer()
        {
            Console.WriteLine("The player name is " + name + " and he is " + age + " years old " + " born in the month of " + month);
        }

    }
}