using System.IO; 
public class Entry
{
    public DateTime Date {get; set;}
    public string _promptText;
    public string _entryText;

    public Entry(DateTime date, string promptText, string entryText)
    {
        Date = date;
        _promptText = promptText;
        _entryText = entryText;
    }


    public void Display()
    {
        // how the entries are presented
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}