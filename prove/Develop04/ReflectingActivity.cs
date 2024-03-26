public class ReflectingActivity : Activity 
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }
    public void Run()
    {
        DisplayStartingMessage();
        Reflect();
        DisplayEndingMessage();
    }
    private void Reflect()
    {
        Random rand = new Random();
        int duration = GetDuration();

        while (duration > 0)
        {
            string prompt = GetRandomPrompt(rand);
            Console.WriteLine(prompt);
            Showspinner(3);

            foreach (string question in _questions)
            {
                Console.WriteLine(question);
                Showspinner(5);
                duration -= 5;
            }

            duration -= 3;
        }
    }
    public string GetRandomPrompt(Random rand)
    {
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}