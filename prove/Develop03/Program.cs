using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("John", 3, 16);
        Reference reference2 = new Reference("Proverbs", 3, 5, 6);

        Scripture scripture1 = new Scripture(reference1, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        Scripture scripture2 = new Scripture(reference2, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        DisplayScripture(scripture1);
        Console.WriteLine("Press Enter to continue or type 'quit' to exit ");
        while (Console.ReadLine().ToLower() != "quit")
        {
            scripture1.HideRandomWord(1);
            DisplayScripture(scripture1);
            if (scripture1.IsCompletelyHidden())
                break;
            Console.WriteLine("Press Enter to continue or type 'quit' to exit");
        }

        DisplayScripture(scripture2);
        Console.WriteLine("Press Enter to continue or type 'quit' to exit");
        while (Console.ReadLine().ToLower() != "quit")
        {
            scripture2.HideRandomWord(1);
            DisplayScripture(scripture2);
            if (scripture2.IsCompletelyHidden())
                break;
            Console.WriteLine("Please Enter to continue or type 'quit' to exit");
        }
    }

    static void DisplayScripture(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}