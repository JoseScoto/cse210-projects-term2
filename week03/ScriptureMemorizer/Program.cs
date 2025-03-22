using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture with a reference and text
        Reference reference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world that he gave his one and begotten Son, that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture = new Scripture(reference, scriptureText);
        
        // Create another scripture with multiple verses
        //Reference multiVerseRef = new Reference("Proverbs", 3, 5, 6);
        //string multiVerseText = "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
        //Scripture multiVerseScripture = new Scripture(multiVerseRef, multiVerseText);
        
        // Use the first scripture for this example
        bool quit = false;
        
        while (!quit && !scripture.IsCompletelyHidden())
        {
            // Clear the console and display the scripture
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            
            // Prompt the user
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit")
            {
                quit = true;
            }
            else
            {
                // Hide a few random words
                scripture.HideRandomWords(3);
            }
        }
        
        // Final display with all words hidden
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        
        if (!quit)
        {
            Console.WriteLine();
            Console.WriteLine("All words are now hidden. Program complete.");
            Console.ReadKey();
        }
    }
}