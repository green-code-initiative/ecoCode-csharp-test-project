namespace RuleTests.Roslyn;

public static class RemoveEmptyFinalizers
{
    public sealed class EmptyFinalizer
    {
        ~EmptyFinalizer() // CA1821
        {
        }
    }

    public sealed class NonEmptyFinalizer
    {
        ~NonEmptyFinalizer()
        {
            Console.WriteLine("Finalizer");
        }
    }
}
