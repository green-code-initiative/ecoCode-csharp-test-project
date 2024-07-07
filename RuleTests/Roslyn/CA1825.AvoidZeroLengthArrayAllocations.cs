namespace RuleTests.Roslyn;

internal static class AvoidZeroLengthArrayAllocations
{
    public static int[] GetEmptyArray() => new int[0]; // CA1825
}
