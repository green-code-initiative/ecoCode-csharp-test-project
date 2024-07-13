namespace RuleTests.Roslyn;

internal static class UsePropertyInsteadOfLinqEnumerableMethod
{
    public static void Test(IReadOnlyList<string> list)
    {
        Console.Write(list.First()); // CA1826
        Console.Write(list.Last()); // CA1826
        Console.Write(list.Count()); // CA1826
    }
}
