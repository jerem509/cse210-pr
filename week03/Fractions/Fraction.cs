public class Fraction
{
    private int _denominator;
    private int _numerator;

    public Fraction()
    {
        _denominator = 1;
        _numerator = 1;
    }

    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _denominator = denominator;
        _numerator = numerator;
    }

    public string GetFractionString()
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{_numerator}/{_denominator}";
        return text;
    }

    public int GetNumerator()
    {
        return _numerator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }
}
