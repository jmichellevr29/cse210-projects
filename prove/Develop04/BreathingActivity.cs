using System.Runtime.CompilerServices;

public class BreathingActivity : Activity 
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }
    public void Run()
    {
        DisplayStartingMessage();
        Breathe();
        DisplayEndingMessage();
    }
    private void Breathe()
    {
        int duration = GetDuration();
        while (duration > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
            duration -= 6;
        }
    }
}