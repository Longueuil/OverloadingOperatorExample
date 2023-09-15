class OverloadingOperatorExample
{
    static void Main(string[] args)
    {
        OverloadPlusOperator overloadPlusOperator1 = new OverloadPlusOperator(2.3, 4.5);
        OverloadPlusOperator overloadPlusOperator2 = new OverloadPlusOperator(6.3, 7.15);
        OverloadPlusOperator result = overloadPlusOperator1 + overloadPlusOperator2;
        Console.WriteLine($"{overloadPlusOperator1.First} + {overloadPlusOperator2.First} = {result.First}");
        Console.WriteLine($"{overloadPlusOperator1.Second} + {overloadPlusOperator2.Second} = {result.Second}");
    }
}

class OverloadPlusOperator
{
    public double First { get; set; }
    public double Second { get; set; }

    public OverloadPlusOperator(double first, double second)
    {
        this.First = first;
        this.Second = second;
    }

    public static OverloadPlusOperator operator +(OverloadPlusOperator a, OverloadPlusOperator b)
    {
        return new OverloadPlusOperator(a.First + b.First, a.Second + b.Second);
    }
}
