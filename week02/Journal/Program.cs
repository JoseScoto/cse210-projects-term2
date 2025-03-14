using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiating classes
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        anEntry.Display();

        Console.WriteLine("Hello World! This is the Journal Project.");
    }
}