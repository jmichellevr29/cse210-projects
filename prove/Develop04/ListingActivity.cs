public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        _count = 0;
    }
    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        GetListFromUser(_prompts[_count]);
        DisplayEndingMessage();
    }
    private void GetRandomPrompt()
    {
        Random rnd = new Random();
        _count = rnd.Next(_prompts.Count);
        Console.WriteLine(_prompts[_count]);
        Console.WriteLine("You have a few seconds to begin thinking about the prompt... ");
        ShowCountDown(5);
    }
    private void GetListFromUser(string prompt)
    {
        Console.WriteLine("Note: To finish your list press enter.");
        Console.WriteLine($"Start listing items for: {prompt}");

        int itemsCount = 0;
        DateTime startTime = DateTime.Now;

        while(true)
        {
            string item = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(item))
                break;
            
            itemsCount++;
        }

        TimeSpan elapsedTime = DateTime.Now - startTime;
        Console.WriteLine($"You listed {itemsCount} items for {prompt} in {(int)elapsedTime.TotalSeconds} seconds.");

    }

}