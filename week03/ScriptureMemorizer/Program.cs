using System;

class Program
{
    static void Main()
    {
        var reference = new Reference("3 Nephi", 20, 42, 43);
        string text = "For ye shall not go before you, and the God of Israel shall be your rearward." + "Behold, my servant shall deal prudently; he shall be exalted and extolled and be very high";

        var scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("Words are hidden. Good job!");
                break;
            }

            Console.Write("Press enter to hide words or type 'quit' to exit: ");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWords(3);
        }
    }
}