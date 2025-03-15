using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiating classes
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            // Get user choice or menu selection
            string choice = Console.ReadLine();

            // If statements to handle selections
            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();

                // Displaying prompt to the user
                Console.WriteLine($"Prompt: {prompt}");
                Console.WriteLine("Your response: ");

                // Get user response
                string response = Console.ReadLine();

                // Asking about the weather. Additional requirement
                Console.Write("What's the weather like today? ");
                string weather = Console.ReadLine();

                // Get current date for the entry
                string date = DateTime.Now.ToShortDateString();

                // Creating new entry
                Entry newEntry = new Entry(date, prompt, response, weather);

                // Adding the entry to the journal
                theJournal.AddEntry(newEntry);  // Changed journal to theJournal

                Console.WriteLine("Entry added successfully!");
            }
            else if (choice == "2")
            {
                // Display all entries
                theJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                // Load entries from file
                Console.Write("Enter the filename to load: ");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                // Save entries to file
                Console.Write("Enter the filename to save: ");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                // Closing the program or app
                running = false;
                Console.WriteLine("Thanks for using the Journal app!");
            }
            else
            {
                // Invalid choices
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}