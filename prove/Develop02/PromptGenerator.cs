public class PromptGenerator
{
    public List<string>_prompt = new List<string>();

    // create list with the prompts 
    public PromptGenerator()
    {
        _prompt.Add("Check in with your body-how is it feeling today?");
        _prompt.Add("What is a positive quality or value that you can focus on?");
        _prompt.Add("An inspirational thought or theme for tomorrow");
        _prompt.Add("What is an intention that you can set for yourself today?");
        _prompt.Add("How are you feeling? What do you notice around you right now?");
    }

    public string GetRandomPrompt()
    {
        // Generate a random inde to get a random prompt from the list
        Random random = new Random();
        int randomIndex = random.Next(0, _prompt.Count);

        // Return a randomly selected prompt;
        return _prompt[randomIndex];
    }
}