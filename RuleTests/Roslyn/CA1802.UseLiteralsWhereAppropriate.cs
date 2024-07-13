namespace RuleTests.Roslyn;

public static class UseLiteralsWhereAppropriate
{
    private static readonly string MyStr = "ShouldBeConst"; // CA1802

    public static void Print() => Console.WriteLine(MyStr);
}
