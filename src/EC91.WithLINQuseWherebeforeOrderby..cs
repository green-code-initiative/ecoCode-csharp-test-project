using System.Linq;
using System.Collections.Generic;
using static EcoCode.LiveWarnings.MakeTypeSealed.SealableClassesWithInterface;

namespace EcoCode.LiveWarnings;

[SuppressMessage("Reliability", "EC91:With LINQ use Where before Order by.", Justification = "When you place the 'orderby' before the 'where', LINQ sorts the entire dataset before filtering it. It is more efficient to filter first and then sort by placing the 'where' before the 'orderby'")]
internal static class WithLINQuseWherebeforeOrderby
{
        public static void Test1()
        {
            List<int> items = new List<int>();

            var query = items.OrderBy(x => x)
                    .Where(x => x > 10)
                    .Select(x => x);
        }
        public static void Test2()
        {
                List<int> items = new List<int>();
                
                var query = items
                .OrderByDescending(x => x)
                .Where(x => x > 10)
                .Select(x => x);
        }
        public static void Test3()
        {
            List<int> items = new List<int>();
            var query = from item in items
                            orderby item
                            where item > 10
                            select item;
        }
        public static void Test4()
        {
            List<int> items = new List<int>();
            var query = from item in items
                            orderby item descending
                            where item > 10
                            select item;
        }
}
