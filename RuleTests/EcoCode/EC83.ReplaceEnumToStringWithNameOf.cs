namespace RuleTests.EcoCode;

internal static class ReplaceEnumToStringWithNameOf
{
    private enum MyEnum { A, B, C, D }

    public static void Run()
    {
        Console.WriteLine(nameof(MyEnum.A));
        Console.WriteLine(nameof(MyEnum.B));
        Console.WriteLine(nameof(MyEnum.C));
        Console.WriteLine(nameof(MyEnum.D));

        Console.WriteLine(MyEnum.A.ToString()); // EC83, code fix: nameof(MyEnum.A)
        Console.WriteLine(MyEnum.B.ToString("")); // EC83, code fix: nameof(MyEnum.B)
        Console.WriteLine(MyEnum.C.ToString(string.Empty)); // EC83, code fix: nameof(MyEnum.C)
        Console.WriteLine(MyEnum.D.ToString(format: null)); // EC83, code fix: nameof(MyEnum.D)

        Console.WriteLine(MyEnum.A.ToString("G")); // EC83, code fix: nameof(MyEnum.A)
        Console.WriteLine(MyEnum.B.ToString("F")); // EC83, code fix: nameof(MyEnum.B)
        Console.WriteLine(MyEnum.C.ToString("N"));

        Console.WriteLine($"{MyEnum.A}"); // EC83, code fix: nameof(MyEnum.A)
        Console.WriteLine($"{MyEnum.B:G}"); // EC83, code fix: nameof(MyEnum.B)
        Console.WriteLine($"{MyEnum.C:F}"); // EC83, code fix: nameof(MyEnum.C)
        Console.WriteLine($"{MyEnum.D:N}");
    }
}
