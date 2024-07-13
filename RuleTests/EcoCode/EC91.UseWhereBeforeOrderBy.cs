namespace RuleTests.EcoCode;

internal static class UseWhereBeforeOrderBy
{
    public static void Test1()
    {
        var items = new List<int>();
        var query = items
            .OrderBy(x => x)
            .Where(x => x > 10) // EC91
            .Select(x => x);
    }

    public static void Test2()
    {
        var items = new List<int>();
        var query = items
            .OrderByDescending(x => x)
            .Where(x => x > 10) // EC91
            .Select(x => x);
    }

    public static void Test3()
    {
        var items = new List<int>();
        var query = from item in items
                    orderby item
                    where item > 10 // EC91
                    select item;
    }

    public static void Test4()
    {
        var items = new List<int>();
        var query = from item in items
                    orderby item descending
                    where item > 10 // EC91
                    select item;
    }
}
