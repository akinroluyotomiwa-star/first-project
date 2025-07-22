using System.Net.Security;

public class Program //class
{
    //Introduction to c#
    //Operators are symbols or keywords that tells a compiler to perform a specific operation on variables , values or object

    public class StudentReportCard
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public int Score { get; set; }
        public string Grade { get; set; }

        public void DisplayPreviousInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"Score: {Score}");
            Console.WriteLine($"Grade: {Grade}");
        }

        public void DisplayCurrentScore()
        {
            Score += 40;
            Console.WriteLine($"Current Score in {Subject}: {Score}");
            // You may want to update the grade based on the new score
            UpdateGrade();
            Console.WriteLine($"Updated Grade: {Grade}");
        }

        private void UpdateGrade()
        {
            if (Score >= 80) Grade = "A";
            else if (Score >= 70) Grade = "B";
            else if (Score >= 60) Grade = "C";
            else if (Score >= 50) Grade = "D";
            else Grade = "F";
        }
    }

    class program //class
    {
        static void Main(string[] args)
        {
            StudentReportCard student = new StudentReportCard();
            student.Name = "John Doe";
            student.Subject = "Mathematics";
            student.Score = 45;
            student.Grade = "D";

            Console.WriteLine("Previous Information:");
            student.DisplayPreviousInfo();

            Console.WriteLine("\nCurrent Score:");
            student.DisplayCurrentScore();
        }
    }
    
        
        
     
    }
    
        
    









