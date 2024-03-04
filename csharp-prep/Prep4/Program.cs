using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbersList = new List<int>();
        int numberUser = -1;

        while (numberUser != 0)
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            numberUser = int.Parse(number);

           if(numberUser != 0)
           {
                numbersList.Add(numberUser);
           }
        }

        int sum = numbersList.Sum();
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum / numbersList.Count);
        Console.WriteLine($"The average is: {average}");

        int max = numbersList.Max();
        Console.WriteLine($"The largest number is: {max}");

    }
}