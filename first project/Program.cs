using System;
using System.ComponentModel.Design;
using System.Diagnostics;
internal class Program
{
    private static void Main(string[] args)
    {
        //Arrays
        //Find highest and lowest score in an array. 

        //declare an array of scores
        int[] scores = { 10, 20, 30, 46, 76, 43, 87 };
         int maxScores = scores[0];
        int minScores = scores[0];

        foreach (int score in scores)
        {
            if (score > maxScores)
                maxScores = score;
            if (score < minScores)
            minScores = score;
        }
        Console.WriteLine($"Highest score : {maxScores} Lowest score: {minScores}");


        //List
        //List<string> names = new List<string>();
        //names.Add("Alice");
        //names.Add("Bob");
        //names.Add("Tomiwa");
        //names.Remove("Alice");

        ////Console.WriteLine("names:");
        //foreach (string s in names)
        //Console.WriteLine(s);
        //names.Add("Alice");
        //Console.WriteLine("Add Alice ");
        //foreach (string s in names)
        //    Console.WriteLine(s);

        // Class Attempt
        //Create a program where users can add / remove student names.
          
        List<string> student = new List<string>();
            student.Add("David");
            student.Add("jamal");
            student.Add("ire");
            student.Remove("David");

            Console.WriteLine("student");
            foreach (string s in student)
            Console.WriteLine(s);
            student.Add("David");
            Console.WriteLine("Add David");
            foreach (string s in student)
                Console.WriteLine(s);



        
          

    }
}
       