public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the most fun I had today?",
        "Where was the most interesting place I saw today?",
        "What was the most interesting conversation I had today?"
    };

    public string GetPrompt()
    {
        Random randGen = new Random();
        string prompt = _prompts[randGen.Next(0, 5)];
        return prompt;
    }
}