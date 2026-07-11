using System;

class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
         "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What are three great things that happened yesterday?",
        "What are 10 things that bring you joy?",
        "What are you looking forward to right now? If you can’t think of anything, what can you do to change that?",
        "What is one totally-free thing that’s transformed your life?",
        "What things in your life would you describe as priceless?"
    };
    
    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}