using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string nameUser = PromptUserName();
        int numberUser = PromptUserNumber();

        int squaredNumber = SquaredNumber(numberUser);

        DisplayResults(nameUser, squaredNumber);
   
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquaredNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResults(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}