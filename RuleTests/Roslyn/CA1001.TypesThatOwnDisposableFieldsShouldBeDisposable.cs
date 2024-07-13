using System.IO;

namespace RuleTests.Roslyn;

public sealed class TypesThatOwnDisposableFieldsShouldBeDisposable // CA1001
{
    private readonly MemoryStream _shouldBeDisposed = new();

    public void Test() => _shouldBeDisposed.Position = 0;
}
