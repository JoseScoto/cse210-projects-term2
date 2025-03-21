using System;
public class Fraction
{
    // Private fields
    private int _top;
    private int _bottom;

    // Constructor #1. Creates a fraction with value 1/1
    public Fraction()
    {
        _top = 1;
        _bottom =1;
    }

    // Constructor #2. Creates a fraction from a whole number like 3 or 3/1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor #3. Fraction with two parameters like 5/3.
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Methods
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text; // Returns a string representing the fraction.
    }

    public double GetDecimalValue()
    {
        // Converts the fraction to a decimal value
        return (double)_top / (double)_bottom;
    }
}