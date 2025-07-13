using System;

public class Reference
{
    private readonly string book;
    private readonly int chapter;
    private readonly int verseStart;
    private readonly int? verseEnd;

    public Reference(string book, int chapter, int verseStart)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.verseEnd = null;

    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.verseEnd = verseEnd;
    }

    public override string ToString()
    {
        if (verseEnd.HasValue)
            return $"{book} {chapter}:{verseStart}-{verseEnd}";
        else
            return $"{book} {chapter}:{verseStart}"; 
    }
}