public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int remainingDuration = GetDuration();
        while (remainingDuration > 0)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(4);

            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(6);

            remainingDuration -= 10; // Each cycle is about 10 seconds
        }

        DisplayEndingMessage();
    }
}