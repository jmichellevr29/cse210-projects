using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int gradeNumber = int.Parse(gradePercentage);

        string letterGrade = "";

        if (gradeNumber >= 90)
        {
          letterGrade = "A"; 
        }
        else if (gradeNumber >= 80)
        {
            letterGrade = "B";
        }
        else if (gradeNumber >= 70)
        {
            letterGrade = "C";
        }
        else if (gradeNumber >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your letter grade is {letterGrade}");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the course.");
        }
        else 
        {
            Console.WriteLine("You have not passed the class. Try next semester.");
        }
    }
}