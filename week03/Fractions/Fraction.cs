public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int whole)
    {
        _numerator = whole;
        _denominator = 1;
    }
    public Fraction(int num, int den)
    {
        _numerator = num;
        _denominator = den;
    }

    public int GetNumerator()
    {
        return _numerator;
    }
    public void SetNumerator(int newNum)
    {
        _numerator = newNum;
    }
    public int GetDenominator()
    {
        return _denominator;
    }
    public void SetDenominator(int newDen)
    {
        _denominator = newDen;
    }
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}