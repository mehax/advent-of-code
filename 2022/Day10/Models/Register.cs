namespace Day10;

internal class Register
{
    public int Value { get; private set; }

    public Register()
    {
        Value = 1;
    }

    public void Add(int value)
    {
        Value += value;
    }
}