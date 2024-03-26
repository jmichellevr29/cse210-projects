public class Activity 
{
    private string _name;
    private string _description;
    private int _duration;
    public string GetName() 
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} Activity...");
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {_duration} seconds.");
        Console.WriteLine("Prepare to begin...");
        // this is for a pause
        Showspinner(5); 
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done! You have completed the {_name} Activity");
        Console.WriteLine($"Duration: {_duration} seconds");
        Showspinner(2);
    }
    public void Showspinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("-");

            Thread.Sleep(1000);
            
            Console.Write("\b \b"); // Erase the + character
            Console.Write("+");
        }

        Console.WriteLine();
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"{i}");
            Thread.Sleep(2000);
        }
    }
        
}