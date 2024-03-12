using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            // this is for the menu that displays
            Console.WriteLine("Welcome to Be Mindful-your journal for wellness!");
            Console.WriteLine("Choose your option");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.WriteLine("Option: ");
            string inputChoice = Console.ReadLine();

            switch (inputChoice)
            {
               case "1":
                DateTime currentDate = DateTime.Now;
                string randomPrompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine($"Prompt: {randomPrompt}");
                Console.Write("Write your response: ");
                string entryText = Console.ReadLine();

                Entry newEntry = new Entry(currentDate, randomPrompt, entryText);
                journal.AddEntry(newEntry);

                Console.WriteLine("Your entry has been added successfully");
                break;

               case "2":
                journal.DisplayAll();
                break;
            
               case "3":
                journal.SaveToFile("Journal.txt");
                Console.WriteLine("Journal saved to file successfully!");
                break;

               case "4":
                journal.LoadFromFile("Journal.txt");
                Console.WriteLine("Journal loaded from file successfully!");
                break;
               
               case "5":
                Environment.Exit(0);
                break;
               
               default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
            
            }
        }
    }
}