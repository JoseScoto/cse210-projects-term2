public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _weather; // Part of the additional requirements

    // Constructor to create new entry
    public Entry(string date, string promptText, string entryText, string weather)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _weather = weather; // Constructor updated for additional requirements
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Weater: {_weather}"); // Part of additional requirements
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine(); // Blank line for readibility
    }
}