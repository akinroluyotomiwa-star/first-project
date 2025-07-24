using System.Diagnostics;

Here are the C# programs for the first assignment using both if-else if and switch statements:

*If-Else If Statement;
using System

class MealSelector
{
    static void Main(string[] args)
    {
        Console.WriteLine("Available menu:");
        Console.WriteLine("1. Rice and Chicken");
        Console.WriteLine("2. Spaghetti");
        Console.WriteLine("3. Pizza");
        Console.WriteLine("4. Salad");

        Console.Write("Enter the name of a meal: ");
        string meal = Console.ReadLine();

        if (meal == "Rice and Chicken")
        {
            Console.WriteLine("You selected Rice and Chicken.");
        }
        else if (meal == "Spaghetti")
        {
            Console.WriteLine("You selected Spaghetti.");
        }
        else if (meal == "Pizza")
        {
            Console.WriteLine("You selected Pizza.");
        }
        else if (meal == "Salad")
        {
            Console.WriteLine("You selected Salad.");
        }
        else if (meal == "none")
        {
            Console.WriteLine("Thank you, goodbye!");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}

Switch Statement;
using System

class MealSelector
{
    static void Main(string[] args)
    {
        Console.WriteLine("Available menu:");
        Console.WriteLine("1. Rice and Chicken");
        Console.WriteLine("2. Spaghetti");
        Console.WriteLine("3. Pizza");
        Console.WriteLine("4. Salad");

        Console.Write("Enter the name of a meal: ");
        string meal = Console.ReadLine();

        switch (meal)
        {
            case "Rice and Chicken":
                Console.WriteLine("You selected Rice and Chicken.");
                break;
            case "Spaghetti":
                Console.WriteLine("You selected Spaghetti.");
                break;
            case "Pizza":
                Console.WriteLine("You selected Pizza.");
                break;
            case "Salad":
                Console.WriteLine("You selected Salad.");
                break;
            case "none":
                Console.WriteLine("Thank you, goodbye!");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}

Both programs will achieve the same result, but the switch statement is often more concise and efficient when dealing with multiple cases.

       