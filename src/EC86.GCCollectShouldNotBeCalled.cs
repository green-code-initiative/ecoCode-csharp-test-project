namespace EcoCode.LiveWarnings;

internal static class GCCollectShouldNotBeCalled
{
    public static void Run()
    {
        // GC.Collect();

        GC.Collect(); // EC86
        
        System.GC.Collect(); // EC86

        GC.Collect(0);

        GC.Collect(2); // EC86

        GC.Collect(0, GCCollectionMode.Optimized);

        GC.Collect(2, GCCollectionMode.Forced); // EC86

        GC.Collect(generation: 0, GCCollectionMode.Optimized);

        GC.Collect(generation: 2, GCCollectionMode.Optimized); // EC86

        GC.Collect(mode: GCCollectionMode.Optimized, generation: 0);

        GC.Collect(mode: GCCollectionMode.Optimized, generation: 2); // EC86
    }
}
