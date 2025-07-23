using System;
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        string pen = "black";
        if (pen == "BLUE")
        {
            Console.WriteLine("do not buy");
        }
        else if (pen == "red")

        {
            Console.WriteLine("do not buy");

        }
        else if (pen == "black")
        {
            Console.WriteLine("buy the pen");


        }
        else
        {
            Console.WriteLine("pen colour not known");

        }

        switch(pen)
        {
            case "Blue":
                Console.WriteLine("do not buy");
                break;
            case "Green":
                Console.WriteLine("do not buy");
                break;
            case "Black":
                Console.WriteLine("buy the pen");
                break;
            default:
                Console.WriteLine("Pen color not known");
                break;
        }
    }
}
       