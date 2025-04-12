using System;

// Eternal Quest Program
// This program helps users track different types of goals with gamification elements.
// It features three types of goals:
// 1. Simple goals - one-time goals that can be completed
// 2. Eternal goals - ongoing goals that can never be "completed" but give points each time
// 3. Checklist goals - goals that must be completed a certain number of times with a bonus

// Exceeding requirements:
// - Added level system based on points (users "level up" as they earn more points)
// - Added achievement system that grants special titles based on goal completions
// - Added motivational quotes when recording goal completions

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Eternal Quest Goal Tracker!");
        Console.WriteLine("Let's achieve your goals one step at a time.");
        
        GoalManager manager = new GoalManager();
        manager.Start();
        
        Console.WriteLine("Thank you for using Eternal Quest Goal Tracker. Goodbye!");
    }
}