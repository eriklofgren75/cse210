using System;

public class Word
{
    private readonly string text;
    private bool hidden;

    public Word(string text)
    {
        this.text = text;
        hidden = false;
    }

    public bool IsHidden => hidden;

    public void Hide()
    {
        hidden = true;
    }
    public override string ToString()
    {
        return hidden ? new string('_', text.Length) : text;
    }
}