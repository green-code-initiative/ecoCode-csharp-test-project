namespace RuleTests.EcoCode;

internal static class ReturnTaskDirectly
{
    public static Task DontWarnWhenReturningTask1() => Task.Delay(0);
    public static Task DontWarnWhenReturningTask2()
    {
        return Task.Delay(0);
    }
    public static Task DontWarnWhenReturningTask3()
    {
        Console.WriteLine();
        return Task.Delay(0);
    }

    public static async Task DontWarnWithMultipleStatements1Async()
    {
        Console.WriteLine();
        await Task.Delay(0).ConfigureAwait(false);
    }
    public static async Task DontWarnWithMultipleStatements2Async()
    {
        await Task.Delay(0).ConfigureAwait(false);
        await Task.Delay(0).ConfigureAwait(false);
    }

    public static async Task WarnOnSingleAwaitExpressionAsync() => // EC93
                                                                   // Comment
        await Task.Delay(0).ConfigureAwait(false);

    public static async Task WarnOnSingleAwaitBody1Async() // EC93
    {
        // Comment 0
        await Task.Delay(0).ConfigureAwait(false); // Comment 1
        // Comment 2
    }

    public static async Task<int> WarnOnSingleAwaitBody2Async() // EC93
    {
        // Comment 0
        return await Task.FromResult(0).ConfigureAwait(false); // Comment 1
        // Comment 2
    }

    public static async Task DontWarnOnNestedAwaitExpressionAsync() =>
        await Task.Delay(await Task.FromResult(0).ConfigureAwait(false)).ConfigureAwait(false);

    public static async Task DontWarnOnNestedAwaitBodyAsync()
    {
        await Task.Delay(await Task.FromResult(0).ConfigureAwait(false)).ConfigureAwait(false);
    }
}
