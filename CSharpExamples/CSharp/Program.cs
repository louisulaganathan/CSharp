using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //ThrowsExpressionSample();
            //ExpressionBodiedMemberExample();
            PatternMatchingExample();
        }
        //C# 7.0 Feature: ThrowsExpression : Throws exception from expression
        private static void ThrowsExpressionSample ()
        {
            ThrowsExpressionSampleClass throwsExpression = new ThrowsExpressionSampleClass("Louis Raj", "Ulaganathan");
            throwsExpression.DisplayName();
            throwsExpression = new ThrowsExpressionSampleClass("Louis Raj", null);
            throwsExpression.DisplayName();
        }
        //C# 6.0 Intro with Method & Read-Only property
        //C# 7.0 Enhanced with Property, Constructor, Finalizer & Indexer
        private static void ExpressionBodiedMemberExample()
        {
            ExpressionBodiedMemberDemo demo = new ExpressionBodiedMemberDemo("Louis Raj");
            demo.displayName();
        }

        //C# 7.0 Pattern matching feature using "is" pattern expression
        private static void PatternMatchingExample()
        {
            PatternMatchingDemo patternMatching = new PatternMatchingDemo();
            patternMatching.Demo();
        }
    }
}
