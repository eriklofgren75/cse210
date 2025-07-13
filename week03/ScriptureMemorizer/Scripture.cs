using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private readonly Reference reference;
    private readonly List<Word> words;
    private readonly Random random = new Random();

    public Scripture(Reference reference, string scriptureText)
    {
        this.reference = reference;
        words = scriptureText.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(w => new Word(w)).ToList();

    }

    public void Display()
    {
        Console.WriteLine(reference);
        Console.WriteLine(string.Join(" ", words));
        Console.WriteLine();

    }

    public void HideRandomWords(int count = 3)
    {
        for (int i = 0; i < count; i++)
        {
            int index = random.Next(words.Count);
            words[index].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(w => w.IsHidden);
    }
}