public class PromptGenerator{
    private List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What moment can you remember from today?",
        "Would you live this day again? Why or why not."
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randIndex = random.Next(_prompts.Count);
        return _prompts[randIndex];
    }
}