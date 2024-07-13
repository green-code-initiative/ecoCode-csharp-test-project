namespace RuleTests.Roslyn;

internal static class DoNotUseCountWhenAnyCanBeUsed
{
    public static bool IsEmpty1(IEnumerable<string> items) => items.Count() == 0;

    public static bool IsEmpty2(IEnumerable<string> items) => items.LongCount() == 0;
}
