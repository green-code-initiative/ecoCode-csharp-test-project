using System.Collections.Immutable;

namespace EcoCode.LiveWarnings;

internal static class DontConcatenateStringsInLoops
{
    #region Regular loops

    public static void DontConcatenateStringsWithParameterAllLoops(string sParam)
    {
        for (int i = 0; i < 10; i++)
        {
            string si = $"{i}";
            sParam += si; // EC75
            sParam = sParam + si; // EC75
            sParam = si + sParam; // EC75
            sParam = si + si;
        }

        foreach (int i in Enumerable.Range(0, 10))
        {
            string si = $"{i}";
            sParam += si; // EC75
            sParam = sParam + si; // EC75
            sParam = si + sParam; // EC75
            sParam = si + si;
        }

        int i2 = 0;
        while (i2++ < 10)
        {
            string si = $"{i2}";
            sParam += si; // EC75
            sParam = sParam + si; // EC75
            sParam = si + sParam; // EC75
            sParam = si + si;
        }

        i2 = 0;
        do
        {
            string si = $"{i2}";
            sParam += si; // EC75
            sParam = sParam + si; // EC75
            sParam = si + sParam; // EC75
            sParam = si + si;
        } while (++i2 < 10);
    }


    private static string sField = string.Empty;
    public static void DontConcatenateStringsWithField()
    {
        for (int i = 0; i < 10; i++)
        {
            string si = $"{i}";
            sField += si; // EC75
            sField = sField + si; // EC75
            sField = si + sField; // EC75
            sField = si + si;
        }
    }

    private static string sProp { get; set; } = string.Empty;
    public static void DontConcatenateStringsWithProperty()
    {
        for (int i = 0; i < 10; i++)
        {
            string si = $"{i}";
            sProp += si; // EC75
            sProp = sProp + si; // EC75
            sProp = si + sProp; // EC75
            sProp = si + si;
        }
    }

    public static void DontConcatenateStringsWithLocal()
    {
        string sLocal = string.Empty;
        for (int i = 0; i < 10; i++)
        {
            string si = $"{i}";
            sLocal += si; // EC75
            sLocal = sLocal + si; // EC75
            sLocal = si + sLocal; // EC75
            sLocal = si + si;

            string sLocalInLoop = string.Empty;
            sLocalInLoop += si;
            sLocalInLoop = sLocalInLoop + si;
            sLocalInLoop = si + sLocalInLoop;
            sLocalInLoop = si + si;
        }
    }

    #endregion

    #region ForEach methods

    public static void DontConcatenateStringsWithForEach<T>()
    {
        string sLocal = string.Empty;

        var arr = new T[1];
        Array.ForEach(arr, i =>
        {
            string si = $"{i}";
            sLocal += si; // EC75
            sLocal = sLocal + si; // EC75
            sLocal = si + sLocal; // EC75
            sLocal = si + si;
        });
        Array.ForEach(arr, i => sLocal += $"{i}"); // EC75
        Array.ForEach(arr, i => sLocal = sLocal + $"{i}"); // EC75
        Array.ForEach(arr, i => sLocal = $"{i}" + sLocal); // EC75
        Array.ForEach(arr, i => sLocal = $"{i}" + $"{i}");

        var list = new List<T>();
        list.ForEach(i =>
        {
            string si = $"{i}";
            sLocal += si; // EC75
            sLocal = sLocal + si; // EC75
            sLocal = si + sLocal; // EC75
            sLocal = si + si;
        });
        list.ForEach(i => sLocal += $"{i}"); // EC75
        list.ForEach(i => sLocal = sLocal + $"{i}"); // EC75
        list.ForEach(i => sLocal = $"{i}" + sLocal); // EC75
        list.ForEach(i => sLocal = $"{i}" + $"{i}");

        var immList = ImmutableList<T>.Empty;
        immList.ForEach(i =>
        {
            string si = $"{i}";
            sLocal += si; // EC75
            sLocal = sLocal + si; // EC75
            sLocal = si + sLocal; // EC75
            sLocal = si + si;
        });
        immList.ForEach(i => sLocal += $"{i}"); // EC75
        immList.ForEach(i => sLocal = sLocal + $"{i}"); // EC75
        immList.ForEach(i => sLocal = $"{i}" + sLocal); // EC75
        immList.ForEach(i => sLocal = $"{i}" + $"{i}");

        _ = Parallel.ForEach(list, i =>
        {
            string si = $"{i}";
            sLocal += si; // EC75
            sLocal = sLocal + si; // EC75
            sLocal = si + sLocal; // EC75
            sLocal = si + si;
        });
        _ = Parallel.ForEach(list, i => sLocal += $"{i}"); // EC75
        _ = Parallel.ForEach(list, i => sLocal = sLocal + $"{i}"); // EC75
        _ = Parallel.ForEach(list, i => sLocal = $"{i}" + sLocal); // EC75
        _ = Parallel.ForEach(list, i => sLocal = $"{i}" + $"{i}");
    }

    public static void DontConcatenateStringsLocalWithForEach<T>()
    {
        var arr = new T[1];
        Array.ForEach(arr, i =>
        {
            string si = $"{i}";
            string sLocal = string.Empty;
            sLocal += si;
            sLocal = sLocal + si;
            sLocal = si + sLocal;
            sLocal = si + si;
        });

        var list = new List<T>();
        list.ForEach(i =>
        {
            string si = $"{i}";
            string sLocal = string.Empty;
            sLocal += si;
            sLocal = sLocal + si;
            sLocal = si + sLocal;
            sLocal = si + si;
        });

        var immList = ImmutableList<T>.Empty;
        immList.ForEach(i =>
        {
            string si = $"{i}";
            string sLocal = string.Empty;
            sLocal += si;
            sLocal = sLocal + si;
            sLocal = si + sLocal;
            sLocal = si + si;
        });

        _ = Parallel.ForEach(list, i =>
        {
            string si = $"{i}";
            string sLocal = string.Empty;
            sLocal += si;
            sLocal = sLocal + si;
            sLocal = si + sLocal;
            sLocal = si + si;
        });
    }

    #endregion
}
