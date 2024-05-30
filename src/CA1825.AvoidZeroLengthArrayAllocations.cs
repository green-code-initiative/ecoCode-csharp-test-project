namespace EcoCode.LiveWarnings;

internal static class AvoidZeroLengthArrayAllocations
{
    public static void Run()
    {
        int[] anZeroLengthArray = new int[0];
        Console.WriteLine(anZeroLengthArray.Length);
    }
}
