namespace RuleTests.Roslyn;

[AttributeUsage(AttributeTargets.Class)]
public class UnsealedAttribute : Attribute  // CA1813
{
}
