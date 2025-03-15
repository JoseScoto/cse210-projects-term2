using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
    public List<string> _prompts;

    // The constructor to initiate the list of prompts 
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "What am I grateful for today?",
            "What is something I want to remember from today?"
        };
    }

    public string GetRandomPrompt()
    {
        // Creating random object
        Random random = new Random();

        // Random index for elements of the list
        int index = random.Next(_prompts.Count);

        // Returning the random prompt 
        return _prompts[index]; 
    }
}