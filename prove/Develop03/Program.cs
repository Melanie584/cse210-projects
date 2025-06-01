using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of scriptures
        List<Scripture> scriptures = new List<Scripture>
    {
        new Scripture(new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart and lean not unto thine own understanding."),
        new Scripture(new Reference("John", 3, 16),
            "For God so loved the world that he gave his only begotten Son."),
        new Scripture(new Reference("2 Nephi", 2, 25),
            "Adam fell that men might be; and men are, that they might have joy.")
    };

        // Show list to user
        Console.WriteLine("Choose a scripture to memorize:\n");

        for (int i = 0; i < scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {scriptures[i].GetReference()}");
        }

        Console.Write("\nEnter the number of the scripture: ");
        string input = Console.ReadLine();
        int choice;

        while (!int.TryParse(input, out choice) || choice < 1 || choice > scriptures.Count)
        {
            Console.Write("Invalid choice. Try again: ");
            input = Console.ReadLine();
        }

        Scripture selectedScripture = scriptures[choice - 1];

        // Main memorization loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");
            string response = Console.ReadLine();

            if (response.ToLower() == "quit" || selectedScripture.IsCompletelyHidden())
                break;

            selectedScripture.HideRandomWords(3);
        }

        Console.WriteLine("Good job! Keep studying!");
    }
}