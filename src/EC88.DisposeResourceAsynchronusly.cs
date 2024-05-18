namespace EcoCode.LiveWarnings;

[SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Valid warning but we don't need it here")]
internal static class DisposeResourceAsynchronusly
{
    private class DisposableClass : IDisposable
    {
        public void Dispose() { }
    }

    private sealed class AsyncDisposableClass : DisposableClass, IAsyncDisposable
    {
        public ValueTask DisposeAsync() => default;
    }

    public static void Run()
    {
        // Dont warn on missing usings
        var d11 = new DisposableClass();
        Console.WriteLine(d11);
        var d12 = new AsyncDisposableClass();
        Console.WriteLine(d12);

        // Dont warn on non-asyncable usings
        using (var d21 = new DisposableClass())
            Console.WriteLine(d21);
        using var d22 = new DisposableClass();
        Console.WriteLine(d22);

        // Dont warn on asyncable usings in non-async method
        using var d31 = new AsyncDisposableClass();
        Console.WriteLine(d31);
        using var d32 = new AsyncDisposableClass();
        Console.WriteLine(d32);
    }

    public static async Task RunAsync()
    {
        // Warn on asyncable usings
        using (var d1 = new AsyncDisposableClass()) // EC88 : Dispose resource asynchronously
            Console.WriteLine(d1);
        using var d2 = new AsyncDisposableClass(); // EC88 : Dispose resource asynchronously
        Console.WriteLine(d2);
        await Task.CompletedTask.ConfigureAwait(false);
    }
}
