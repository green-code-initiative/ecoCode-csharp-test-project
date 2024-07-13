namespace RuleTests.Roslyn;

public sealed class DoNotInitializeUnnecessarily
{
    public int MyInt { get; } = 0; // CA1805

    public string? MyStr { get; } = null; // CA1805
}
