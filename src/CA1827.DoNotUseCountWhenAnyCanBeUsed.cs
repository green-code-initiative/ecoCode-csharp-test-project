using System.Linq;

namespace EcoCode.LiveWarnings;

internal static class DoNotUseCountWhenAnyCanBeUsed
{
    public static async Task<string> M1Async(IQueryable<string> list)
        => await list.CountAsync() != 0 ? "Not empty" : "Empty";

    public async Task<string> M2Async(IQueryable<string> list)
        => await list.LongCountAsync() > 0 ? "Not empty" : "Empty";
}
