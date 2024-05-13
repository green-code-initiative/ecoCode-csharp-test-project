namespace EcoCode.LiveWarnings;

internal static class DontConcatenateStringsInLoops
{
    private static string s1 = string.Empty;
    private static string s2 = string.Empty;

    public static void Run(string s0)
    {
        for (int i = 0; i < 10; i++)
            s0 += i; // EC75
        for (int i = 0; i < 10; i++)
            s0 = i.ToString(provider: null);
        Console.WriteLine(s0);

        for (int i = 0; i < 10; i++)
            s1 += i; // EC75
        for (int i = 0; i < 10; i++)
            s1 = i.ToString(provider: null);
        Console.WriteLine(s1);

        for (int i = 0; i < 10; i++)
            s2 += i; // EC75
        for (int i = 0; i < 10; i++)
            s2 = i.ToString(provider: null);
        Console.WriteLine(s2);

        string s3 = string.Empty;
        for (int i = 0; i < 10; i++)
            s3 += i; // EC75
        for (int i = 0; i < 10; i++)
            s3 = i.ToString(provider: null);
        Console.WriteLine(s3);
    }
}
