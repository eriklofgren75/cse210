using System;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string prompt, string entryText)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd");
        _promptText = prompt;
        _entryText = entryText;
    }
    public string GetSaveFormat()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }

    public static Entry FromSavedString(string line)
    {
        var parts = line.Split('|');
        return new Entry(parts[1], parts[2]) { _date = parts[0] };
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}\n");
    }
}