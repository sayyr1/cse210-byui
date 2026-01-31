using System;

class Program
{
    static void Main(string[] args)
    {
        // 1) Create a reference (single verse OR range)
        // Example range: Proverbs 3:5-6
        Reference reference = new Reference("Nephi", 3, 7);

        // 2) Create the scripture text
        string text =
          "And it came to pass that I, Nephi, said unto my father: I will go and do the things " +
    "which the Lord hath commanded, for I know that the Lord giveth no commandments unto " +
    "the children of men, save he shall prepare a way for them that they may accomplish " +
    "the thing which he commandeth them.";

        Scripture scripture = new Scripture(reference, text);

        // Main loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to finish: ");

            string input = Console.ReadLine()?.Trim() ?? "";

            if (input.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            // Hide a few random words (core requirement allows re-hiding already hidden words)
            scripture.HideRandomWords(3);

            // End when all words are hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("All words are hidden. Program ended.");
                break;
            }
        }
    }
}
