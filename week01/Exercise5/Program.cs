using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string name = PromptUserName();
        int favNumber = PromptUserNumber();
        double squareValue = SquareNumber(favNumber);
        DisplayResult(name, squareValue);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        return int.Parse(number);
    }

    static double SquareNumber(int favNumber)
    {
        double squareRoot = favNumber * favNumber;
        return squareRoot;
    }

    static void DisplayResult(string name, double squareValue)
    {
        Console.WriteLine($"Brother {name}, the square of your number is {squareValue}");
    }
}

