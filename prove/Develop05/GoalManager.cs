public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        LoadGoals();
        while(true)
        {
            Console.WriteLine("\n--- Goal Tracker ---");
            Console.WriteLine("1. Display Score");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Create Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");

            Console.Write("Enter your choice: ");
            var choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    CreateGoal();
                    break;
                case "4":
                    RecordEvent();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    SaveGoals();
                    Console.WriteLine("Goals saved. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player score: {_score}");
    }
    public void ListGoals()
    {
        Console.WriteLine("\n--- Your Goals ---");
        foreach (var goal in _goals)
        {
            string completionStatus = goal.IsComplete() ? "[X]" : "[ ]";
            if (goal is ChecklistGoal checklistGoal)
            {
                completionStatus += $"Completed {checklistGoal.GetProgress()}/{checklistGoal.GetTarget()} times";
            }
            Console.WriteLine($"{completionStatus} {goal.GetName()}");
        }
    }
    public void CreateGoal()
    {
        Console.Write("Enter goal type (Simple/Eternal/Checklist): ");
        var type = Console.ReadLine().ToLower();
        Console.Write("Enter goal name: ");
        var name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        var description = Console.ReadLine();
        Console.Write("Enter points for the goal: ");
        var points = int.Parse(Console.ReadLine());
        
        switch (type)
        {
            case "simple":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "eternal":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "checklist":
                Console.Write("Enter target count for the goal: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completing the goal: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
               Console.WriteLine("Invalid goal type. Goal not created.");
               break;

        }
    }
    public void RecordEvent()
    {
        Console.Write("Enter the name of the goal you completed: ");
        var name = Console.ReadLine();

        var goal = _goals.Find(g => g.GetName() == name );
        if (goal != null) 
        {
            goal.RecordEvent();
            _score += goal.GetPoints() + (goal is ChecklistGoal checklistGoal ? checklistGoal.GetBonusPoints() : 0);
            if (goal.IsComplete())
            {
                _score += goal.GetBonusPoints();
                Console.WriteLine("Congratulations! You've completed the goal and earned bonus points!");
            }
            else 
            {
                Console.WriteLine("Goal not found.");
            }

        }
    }
    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine($"{goal.GetName()}, {goal.GetDescription()}, {goal.GetPoints()}, {goal.GetProgress()}");
                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"{checklistGoal.GetTarget()}, {checklistGoal.GetBonusPoints()}");
                }
            }
        }
    }
    public void LoadGoals()
    {
        _goals.Clear();
        if(File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string[] parts = reader.ReadLine().Split(",");
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    int progress = int.Parse(parts[3]);

                    if (progress > 0)
                    {
                        int target = int.Parse(parts[4]);
                        int bonus = int.Parse(parts[5]);
                        _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                    }
                    else 
                    {
                        _goals.Add(new SimpleGoal(name, description, points));

                    }
                }
            }
        }
    }
}