namespace EcoCode.LiveWarnings;

internal static class DoNotUseCountWhenAnyCanBeUsed
{
    public static string M1(IEnumerable<string> list)
        => list.Count() != 0 ? "Not empty" : "Empty";

    public static string M2(IEnumerable<string> list)
        => list.LongCount() > 0 ? "Not empty" : "Empty";
}
