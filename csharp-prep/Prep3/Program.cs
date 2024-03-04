using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // int secretNumber = 5; 

        // Console.WriteLine("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int number = int.Parse(magicNumber);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int number = -1;

        while (number != magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            string guess = Console.ReadLine();
            number = int.Parse(guess);

            if (magicNumber > number)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < number)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You guessed the magic number.");
            }
        }


    }
}