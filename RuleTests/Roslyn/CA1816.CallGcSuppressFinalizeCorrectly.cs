namespace RuleTests.Roslyn;

public static class CallGcSuppressFinalizeCorrectly
{
    // In an unsealed class, a method that's an implementation of IDisposable.Dispose and doesn't call GC.SuppressFinalize
    public class Case1 : IDisposable
    {
        private readonly IDisposable _item = null!;

        public void Dispose() => _item.Dispose(); // CA1816
    }

    // A method that's not an implementation of IDisposable.Dispose and calls GC.SuppressFinalize
    public class Case2
    {
        public void Test() => GC.SuppressFinalize(this); // CA1816
    }

    // A method that calls GC.SuppressFinalize and passes something other than this.
    public sealed class Case3 : IDisposable
    {
        private readonly IDisposable _item = null!;

        public void Dispose()
        {
            _item.Dispose();
            GC.SuppressFinalize(_item); // CA1816
        }
    }
}
