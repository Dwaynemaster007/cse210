using System;

public class Fraction
{
    // Private attributes (Encapsulation)
    private int _top;
    private int _bottom;

    // 1. Constructor with no parameters (1/1)
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // 2. Constructor with 1 parameter (top/1)
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // 3. Constructor with 2 parameters (top/bottom)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters and Setters for _top
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    // Getters and Setters for _bottom
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Returns fraction as a string representation (e.g. "3/4")
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns the calculated decimal value
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}