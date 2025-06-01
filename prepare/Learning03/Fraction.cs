using System.Runtime.CompilerServices;

/// <summary>
/// Represents a fraction with a numerator and denominator.
/// This is more accurate than storing numbers in a double.
/// </summary>
public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int whole)
    {
        _top = whole;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string representation = $"{_top} / {_bottom}";
        return representation;
    }
    public double GetDecimalValue()
    {
        double value = (double)_top / (double)_bottom;
        return value;
    }
}