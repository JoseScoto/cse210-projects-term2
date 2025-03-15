using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;

    // Constructor to initialize the list of entries
    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        // Add new entry to the list
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        // Displaying each entry in the journal
        Console.WriteLine("\n=== Journal Entries ===");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        // Create a StreamWriter to write to the file
        using (StreamWriter writer = new StreamWriter(file))
        {
            // Write each entry to the file
            foreach (Entry entry in _entries)
            {
                // Added weather note as extra requirement
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}|{entry._weather}");
            }
        }

        Console.WriteLine($"Journal saved to {file}");
    }

    public void LoadFromFile(string file)
    {
        // Clear existing entries
        _entries.Clear();

        // Checking if file exists
        if (!File.Exists(file))
        {
            Console.WriteLine($"File {file} not found.");
            return;
        }

        string[] lines = File.ReadAllLines(file);

        // Processing each line and creating entries
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            // Checking if line has the expected format
            if (parts.Length == 3)
            {
                string date = parts[0];
                string promptText = parts[1];
                string entryText = parts[2];
                string weather = parts[3]; // Additional requirement

                // Creating new entry and adding it to the journal
                Entry entry = new Entry(date, promptText, entryText, weather);
                _entries.Add(entry);
            }
        }
        Console.WriteLine($"Loaded {_entries.Count} entries from {file}");
    }
}
