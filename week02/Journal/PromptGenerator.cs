using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What is something I am grateful for today?",
        "How did I show love or kindness to someone today?",
        "What is one thing I could improve for tomorrow?",
        "Who helped me today, and how?",
        "What is one thing I want to remember about today?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}