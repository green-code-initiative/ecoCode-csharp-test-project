namespace RuleTests.Roslyn;

public static class MarkMembersAsStatic
{
    public class Test
    {
        public void Method() // CA1822
        {
        }
    }
}
