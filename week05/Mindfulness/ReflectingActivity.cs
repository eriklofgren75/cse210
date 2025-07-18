using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time you achieved a personal goal."
    };

    private List<string> _questions = new List<string>()
    {
        "How did your experience make you feel?",
        "What did you learn from this experience?",
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "What is your favorite thing about this experience?"

    };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on experiences in your life.")
    {

    }

    public void Run()
    {
        StartActivity();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        DisplaySpinner(3);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string question = _questions[random.Next(_questions.Count)];
            Console.WriteLine(question);
            DisplaySpinner(5);
            Console.WriteLine();

        }

        EndActivity();

    }
}