using System.Net.Security;

public class Program //class
{
    //Introduction to c#
    //Operators are symbols or keywords that tells a compiler to perform a specific operation on variables , values or object

    private static void Main(string[] args) // entry point
    {
        PLAYERS players = new PLAYERS();
        players.displayinfo();
        players.levelup();
    }
    //Create a player class with properties for name(string), age(int), and score(int).
    //Method: Displayinfo() shows the players  name, age, and score.
    //2nd Method: LevelUp() increases the score by 10 and displays a message.
   
    class PLAYERS
    {
        string name = "tomiwa";
        int age = 13;
        int score = 91;
        public void displayinfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(score);

        }
        public void levelup()
        {
            score += 10;
            Console.WriteLine("level up score: " + score);
        }
    }
}








