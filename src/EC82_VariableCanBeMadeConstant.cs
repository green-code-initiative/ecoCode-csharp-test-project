namespace EcoCode.LiveWarnings;

internal static class EC82_VariableCanBeMadeConstant
{
    public static void Run()
    {
        int i0 = 0; // EC82, code fix: const int i0 = 0;
        Console.WriteLine(i0);

        int i1 = 0;
        Console.WriteLine(i1++);

        const int i2 = 0;
        Console.WriteLine(i2);

        int i3;
        i3 = 0;
        Console.WriteLine(i3);

        int i4 = DateTime.Now.DayOfYear;
        Console.WriteLine(i4);

        int i5 = 0, i6 = DateTime.Now.DayOfYear;
        Console.WriteLine(i5);
        Console.WriteLine(i6);

        int i7 = 0, i8 = 0; // EC82, code fix: const int i7 = 0, i8 = 0;
        Console.WriteLine(i7);
        Console.WriteLine(i8);

        object o = "abc";
        Console.WriteLine(o);

        string s = "abc"; // EC82, code fix: const string s = "abc";
        Console.WriteLine(s);

        var v0 = 4; // EC82, code fix: const int item = 4;
        Console.WriteLine(v0);

        var v1 = "abc"; // EC82, code fix: const string item = "abc";
        Console.WriteLine(v1);
    }
}
