namespace EcoCode.LiveWarnings;

internal static class EC69_DontCallFunctionsInLoopConditions
{
    private const int C = 10;
    private static int V1 => 10;
    private static int V2() => 10;
    private static int V3(int i) => i;

    public static void Run(int p)
    {
        int i, j = 0, k = 10;

        // EC69 on V2(), V3(k), V3(p) and V3(C)

        for (i = 0; i < V1 && i < V2() && i < V3(i) && i < V3(j) && i < V3(k) && i < V3(p) && i < V3(C); i++)
            j += i;

        while (i < V1 && i < V2() && i < V3(i) && i < V3(j) && i < V3(k) && i < V3(p) && i < V3(C))
            j += i++;

        do j += i++;
        while (i < V1 && i < V2() && i < V3(i) && i < V3(j) && i < V3(k) && i < V3(p) && i < V3(C));
    }
}
