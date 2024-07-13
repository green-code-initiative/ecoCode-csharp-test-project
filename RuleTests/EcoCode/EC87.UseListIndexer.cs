namespace RuleTests.EcoCode;

internal static class UseListIndexer
{
    private sealed class MyCollection1<T> : List<T>;
    private sealed class MyCollection2<T> : List<T>
    {
        public T First() => this[0];
        public T Last() => this[^1];
        public T ElementAt(int index) => this[index];
    }

    private static readonly int[] Arr = [1, 2, 3];
    private static readonly List<int> List = [1, 2, 3];
    private static readonly MyCollection1<int> Coll1 = [1, 2, 3];
    private static readonly MyCollection2<int> Coll2 = [1, 2, 3];
    private static readonly HashSet<int> Set = [1, 2, 3];
    private static readonly Dictionary<int, int> Dic = new() { { 1, 1 }, { 2, 2 }, { 3, 3 } };
    private static readonly IEnumerable<int> Enm = Enumerable.Range(0, 10);

    public static void Run()
    {
        Console.WriteLine(Arr.First()); // EC87
        Console.WriteLine(Arr.First(x => x != 1));
        Console.WriteLine(Arr.Last()); // EC87
        Console.WriteLine(Arr.Last(x => x != 1));
        Console.WriteLine(Arr.ElementAt(2)); // EC87

        Console.WriteLine(List.First()); // EC87
        Console.WriteLine(List.First(x => x != 1));
        Console.WriteLine(List.Last()); // EC87
        Console.WriteLine(List.Last(x => x != 1));
        Console.WriteLine(List.ElementAt(2)); // EC87

        Console.WriteLine(Coll1.First()); // EC87
        Console.WriteLine(Coll1.First(x => x != 1));
        Console.WriteLine(Coll1.Last()); // EC87
        Console.WriteLine(Coll1.Last(x => x != 1));
        Console.WriteLine(Coll1.ElementAt(2)); // EC87

        Console.WriteLine(Coll2.First());
        Console.WriteLine(Coll2.First(x => x != 1));
        Console.WriteLine(Coll2.Last());
        Console.WriteLine(Coll2.Last(x => x != 1));
        Console.WriteLine(Coll2.ElementAt(2));

        Console.WriteLine(Set.First());
        Console.WriteLine(Set.Last());
        Console.WriteLine(Set.ElementAt(2));

        Console.WriteLine(Dic.First());
        Console.WriteLine(Dic.Last());
        Console.WriteLine(Dic.ElementAt(2));

        Console.WriteLine(Enm.First());
        Console.WriteLine(Enm.Last());
        Console.WriteLine(Enm.ElementAt(2));
    }
}
