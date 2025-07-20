using System.Net.Security;
using System.Xml.Serialization;

public class Program //class
{
    //Introduction to c#
    //Operators are symbols or keywords that tells a compiler to perform a specific operation on variables , values or object

    private static void Main(string[] args) // entry point
    {
        MultiplicationTable();

        multiply multiply = new multiply();
        multiply.MultiplicationTables();

    }

    public static void MultiplicationTable()
    {
        int b = 10;
        Console.WriteLine(b * 1);
        Console.WriteLine(b * 2);
        Console.WriteLine(b * 3);
        Console.WriteLine(b * 4);
        Console.WriteLine(b * 5);
        Console.WriteLine(b * 6);
        Console.WriteLine(b * 7);
        Console.WriteLine(b * 8);
        Console.WriteLine(b * 9);
        Console.WriteLine(b * 10);
        Console.WriteLine(b * 11);
        Console.WriteLine(b * 12);
    }
   
    //creating a new class
    //multiplication table 10()
    class multiply
    {
        int b = 10;

        public void MultiplicationTables()
        {
            Console.WriteLine(b * 1);
            Console.WriteLine(b * 2);
            Console.WriteLine(b * 3);
            Console.WriteLine(b * 4);
            Console.WriteLine(b * 5);
            Console.WriteLine(b * 6);
            Console.WriteLine(b * 7);
            Console.WriteLine(b * 8);
            Console.WriteLine(b * 9);
            Console.WriteLine(b * 10);
            Console.WriteLine(b * 11);
            Console.WriteLine(b * 12);

        }


    }
}









