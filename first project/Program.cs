using System.Net.Security;
using System.Xml.Serialization;

public class Program //class
{
    //Introduction to c#
    //Operators are symbols or keywords that tells a compiler to perform a specific operation on variables , values or object

    private static void Main(string[] args) // entry point
    {
        MultiplicationTable();// call a method
        //create an instance of an object
        multiply multiply = new multiply();
        multiply.MultiplicationTables();

    }

    public static void MultiplicationTable()//method
    {
        int d = 5;
        Console.WriteLine(d * 1);
        Console.WriteLine(d * 2);
        Console.WriteLine(d * 3);
        Console.WriteLine(d * 4);
        Console.WriteLine(d * 5);
        Console.WriteLine(d * 6);
        Console.WriteLine(d * 7);
        Console.WriteLine(d * 8);
        Console.WriteLine(d * 9);
        Console.WriteLine(d * 10);
        Console.WriteLine(d * 11);
        Console.WriteLine(d * 12);
    }
   
    //creating a new class
    //multiplication table 10()
    class multiply
    {
        int d = 5;

        public void MultiplicationTables()
        {
            Console.WriteLine(d * 1);
            Console.WriteLine(d * 2);
            Console.WriteLine(d * 3);
            Console.WriteLine(d * 4);
            Console.WriteLine(d * 5);
            Console.WriteLine(d * 6);
            Console.WriteLine(d * 7);
            Console.WriteLine(d * 8);
            Console.WriteLine(d * 9);
            Console.WriteLine(d * 10);
            Console.WriteLine(d * 11);
            Console.WriteLine(d * 12);

        }


    }
}









