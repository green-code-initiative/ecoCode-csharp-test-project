namespace EcoCode.LiveWarnings;

internal static class EC85_MakeTypeSealed
{
    public static class SealableClasses
    {
        public class TestA; // EC85: make type sealed
        internal class TestB; // EC85: make type sealed
        public static class Test0
        {
            public class Test01; // EC85: make type sealed
            internal class Test02; // EC85: make type sealed
            private class Test03; // EC85: make type sealed
        }
        internal static class Test1
        {
            public class Test11; // EC85: make type sealed
            internal class Test12; // EC85: make type sealed
            private class Test13; // EC85: make type sealed
        }
    }

    public static class SealableRecords
    {
        public record TestA; // EC85: make type sealed
        internal record TestB; // EC85: make type sealed
        public static class Test0
        {
            public record Test01; // EC85: make type sealed
            internal record Test02; // EC85: make type sealed
            private record Test03; // EC85: make type sealed
        }
        internal static class Test1
        {
            public record Test11; // EC85: make type sealed
            internal record Test12; // EC85: make type sealed
            private record Test13; // EC85: make type sealed
        }
    }

    public static class NonSealableStructs
    {
        public struct TestA;
        internal struct TestB;
        public static class Test0
        {
            public struct Test01;
            internal struct Test02;
            private struct Test03;
        }
        internal static class Test1
        {
            public struct Test11;
            internal struct Test12;
            private struct Test13;
        }
    }

    public static class StaticClasses
    {
        public static class Test0
        {
            public static class Test01;
            internal static class Test02;
            private static class Test03;
        }
        internal static class Test1
        {
            public static class Test11;
            internal static class Test12;
            private static class Test13;
        }
    }

    public static class AbstractClasses
    {
        public abstract class TestA;
        internal abstract class TestB;
        public static class Test0
        {
            public abstract class Test01;
            internal abstract class Test02;
            private abstract class Test03;
        }
        internal static class Test1
        {
            public abstract class Test11;
            internal abstract class Test12;
            private abstract class Test13;
        }
    }

    public static class SealedClasses
    {
        public sealed class TestA;
        internal sealed class TestB;
        public static class Test0
        {
            public sealed class Test01;
            internal sealed class Test02;
            private sealed class Test03;
        }
        internal static class Test1
        {
            public sealed class Test11;
            internal sealed class Test12;
            private sealed class Test13;
        }
    }

    public static class SealableClassesWithInterface
    {
        public interface ITest { void Method(); }
        public class TestA : ITest { public void Method() { } } // EC85: make type sealed
        internal class TestB : ITest { public void Method() { } } // EC85: make type sealed
        public static class Test0
        {
            public class Test01 : ITest { public void Method() { } } // EC85: make type sealed
            internal class Test02 : ITest { public void Method() { } } // EC85: make type sealed
            private class Test03 : ITest { public void Method() { } } // EC85: make type sealed
        }
        internal static class Test1
        {
            public class Test11 : ITest { public void Method() { } } // EC85: make type sealed
            internal class Test12 : ITest { public void Method() { } } // EC85: make type sealed
            private class Test13 : ITest { public void Method() { } } // EC85: make type sealed
        }
    }

    public static class SealableClassesWithOverridable
    {
        public class TestA1 { public virtual void Method() { } }
        public class TestA2 { internal virtual void Method() { } } // EC85: make type sealed
        public class TestA3 { protected virtual void Method() { } }
        public class TestA4 { protected internal virtual void Method() { } } // EC85: make type sealed
        public class TestA5 { private protected virtual void Method() { } } // EC85: make type sealed

        internal class TestB1 { public virtual void Method() { } } // EC85: make type sealed
        internal class TestB2 { internal virtual void Method() { } } // EC85: make type sealed
        internal class TestB3 { protected virtual void Method() { } } // EC85: make type sealed
        internal class TestB4 { protected internal virtual void Method() { } } // EC85: make type sealed
        internal class TestB5 { private protected virtual void Method() { } } // EC85: make type sealed

        public static class Test0
        {
            public class TestA1 { public virtual void Method() { } }
            public class TestA2 { internal virtual void Method() { } } // EC85: make type sealed
            public class TestA3 { protected virtual void Method() { } }
            public class TestA4 { protected internal virtual void Method() { } } // EC85: make type sealed
            public class TestA5 { private protected virtual void Method() { } } // EC85: make type sealed
        
            internal class TestB1 { public virtual void Method() { } } // EC85: make type sealed
            internal class TestB2 { internal virtual void Method() { } } // EC85: make type sealed
            internal class TestB3 { protected virtual void Method() { } } // EC85: make type sealed
            internal class TestB4 { protected internal virtual void Method() { } } // EC85: make type sealed
            internal class TestB5 { private protected virtual void Method() { } } // EC85: make type sealed

            private class TestC1 { public virtual void Method() { } } // EC85: make type sealed
            private class TestC2 { internal virtual void Method() { } } // EC85: make type sealed
            private class TestC3 { protected virtual void Method() { } } // EC85: make type sealed
            private class TestC4 { protected internal virtual void Method() { } } // EC85: make type sealed
            private class TestC5 { private protected virtual void Method() { } } // EC85: make type sealed
        }

        internal static class Test1
        {
            public class TestA1 { public virtual void Method() { } } // EC85: make type sealed
            public class TestA2 { internal virtual void Method() { } } // EC85: make type sealed
            public class TestA3 { protected virtual void Method() { } } // EC85: make type sealed
            public class TestA4 { protected internal virtual void Method() { } } // EC85: make type sealed
            public class TestA5 { private protected virtual void Method() { } } // EC85: make type sealed
        
            internal class TestB1 { public virtual void Method() { } } // EC85: make type sealed
            internal class TestB2 { internal virtual void Method() { } } // EC85: make type sealed
            internal class TestB3 { protected virtual void Method() { } } // EC85: make type sealed
            internal class TestB4 { protected internal virtual void Method() { } } // EC85: make type sealed
            internal class TestB5 { private protected virtual void Method() { } } // EC85: make type sealed
        
            private class TestC1 { public virtual void Method() { } } // EC85: make type sealed
            private class TestC2 { internal virtual void Method() { } } // EC85: make type sealed
            private class TestC3 { protected virtual void Method() { } } // EC85: make type sealed
            private class TestC4 { protected internal virtual void Method() { } } // EC85: make type sealed
            private class TestC5 { private protected virtual void Method() { } } // EC85: make type sealed
        }
    }

    public static class Inheritance
    {
        public abstract class Test2 { public virtual void Overridable() { } }
        public class Test3 : Test2;
        public sealed class Test4 : Test3;
        public class Test5 : Test3;
        public class Test6 : Test3 { public override void Overridable() { } }
        public class Test7 : Test3 { public sealed override void Overridable() { } } // EC85: make type sealed
        public class Test8 : Test3 { public sealed override void Overridable() { } }
        public class Test9 : Test8; // EC85: make type sealed
    }

    public static class Partial
    {
        public partial class Test1; // EC85: make type sealed
        partial class Test1 { private readonly int Value; public int Method() => Value; }

        partial class Test2 { private readonly int Value; public int Method() => Value; }
        public partial class Test2; // EC85: make type sealed

        public partial class Test3;
        partial class Test3 { public virtual void Method() { } }

        public partial class Test4;
        sealed partial class Test4 { private readonly int Value; public int Method() => Value; }
    }
}
