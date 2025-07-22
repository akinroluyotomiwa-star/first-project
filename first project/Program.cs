using System.Net.Security;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        double myDouble = 9.78;
        int myInt = (int)myDouble;  // Manual casting: double to int

        Console.WriteLine(myDouble);
        Console.WriteLine(myInt);
        //        // create a user name
        //        Console.WriteLine("Enter your name:");
        //        string username = Console.ReadLine();

        //        Console.WriteLine(username);

        //        // create a state
        //        Console.WriteLine("your state");
        //        string state = Console.ReadLine();
        //        // create blood group
        //        Console.WriteLine("blood group");
        //        string bloodgroup = Console.ReadLine();

        //        Console.WriteLine("You entered: ");
        //        Console.WriteLine("Name: " + username);
        //        Console.WriteLine("State: " +  state);
        //        Console.WriteLine("BloodGroup" + bloodgroup);

        //if (10 > 6)
        //Console.WriteLine("print true");

        //if (10 < 6)
        //{
        //    Console.WriteLine(true);
        //}
        //else
        //{
        //    Console.WriteLine(false);
        //    int score = 10;
        //}

        int score = 10;
        score -= 10;

        if (score > 10)
            Console.WriteLine("grade A");
        else if (score > 50)
            Console.WriteLine("grade B");

        int day = 4;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
        }
        // Outputs "Thursday" (day 4)
    }
}







