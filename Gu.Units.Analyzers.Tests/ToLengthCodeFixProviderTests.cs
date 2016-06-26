﻿namespace Gu.Units.Analyzers.Tests
{
    using System;

    using Microsoft.CodeAnalysis.CodeFixes;
    using Microsoft.CodeAnalysis.Diagnostics;

    using NUnit.Framework;

    public class ToLengthCodeFixProviderTests : CodeFixVerifier
    {
        [Test]
        public void IntToMillimetres()
        {
            var before = @"
    namespace ConsoleApplication1
    {
        using Gu.Units;

        public class Foo
        {   
            public Foo()
            {
                Bar = 1;
            }

            public Length Bar { get; }
        }
    }";

            var expected = @"
    namespace ConsoleApplication1
    {
        using Gu.Units;

        public class Foo
        {   
            public Foo()
            {
                Bar = Length.FromMillimetres(1);
            }

            public Length Bar { get; }
        }
    }";
            this.VerifyCSharpFix(before, expected);
        }

        [Test]
        public void NegativeIntToMillimetres()
        {
            var before = @"
    namespace ConsoleApplication1
    {
        using Gu.Units;

        public class Foo
        {   
            public Foo()
            {
                Bar = -1;
            }

            public Length Bar { get; }
        }
    }";

            var expected = @"
    namespace ConsoleApplication1
    {
        using Gu.Units;

        public class Foo
        {   
            public Foo()
            {
                Bar = Length.FromMillimetres(-1);
            }

            public Length Bar { get; }
        }
    }";
            this.VerifyCSharpFix(before, expected);
        }

        [Test]
        public void DoubleToMillimetres()
        {
            var before = @"
    namespace ConsoleApplication1
    {
        using Gu.Units;

        public class Foo
        {   
            public Foo()
            {
                Bar = 1.2;
            }

            public Length Bar { get; }
        }
    }";

            var expected = @"
    namespace ConsoleApplication1
    {
        using Gu.Units;

        public class Foo
        {   
            public Foo()
            {
                Bar = Length.FromMillimetres(1.2);
            }

            public Length Bar { get; }
        }
    }";
            this.VerifyCSharpFix(before, expected);
        }

        [Test]
        public void NegativeDoubleToMillimetres()
        {
            var before = @"
    namespace ConsoleApplication1
    {
        using Gu.Units;

        public class Foo
        {   
            public Length Bar { get; } = -1.2;
        }
    }";

            var expected = @"
    namespace ConsoleApplication1
    {
        using Gu.Units;

        public class Foo
        {   
            public Length Bar { get; } = Length.FromMillimetres(-1.2);
        }
    }";
            this.VerifyCSharpFix(before, expected);
        }

        protected override CodeFixProvider GetCSharpCodeFixProvider()
        {
            return new ToLengthCodeFixProvider();
        }

        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            throw new Exception();
            //return new TestAnalyzerAnalyzer();
        }
    }
}