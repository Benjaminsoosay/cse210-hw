
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!\n");

        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son"),
            new Scripture("Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding"),
            new Scripture("Psalm 23:1", "The Lord is my shepherd, I lack nothing")
        };

        var random = new Random();
        Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            if (selectedScripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden. Press Enter to exit.");
                Console.ReadLine();
                break;
            }

            selectedScripture.HideRandomWords(); // Now works with default value
        }
    }
}
