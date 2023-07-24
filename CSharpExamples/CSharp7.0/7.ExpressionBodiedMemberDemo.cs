using System;
namespace CSharp
{
    //This expressiosn bodied member feature was available in C# 6.0 itself for methods & read-only properties.
    //This feature is extended to constructor, destructors, indexers
    public class ExpressionBodiedMemberDemo
    {
        private string firstName;
        //Expression bodied constructor
        public ExpressionBodiedMemberDemo(string fName) => FirstName = fName;

        //Expression bodied property
        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        //Expression bodied method
        public void displayName() => Console.WriteLine($"First Name : {FirstName}");


        //C# 6.0 Intro with Method & Read-Only property
        //C# 7.0 Enhanced with Property, Constructor, Finalizer & Indexer
        public static void Main(string[] args)
        {
            ExpressionBodiedMemberDemo demo = new ExpressionBodiedMemberDemo("Louis Raj");
            demo.displayName();
        }
    }
}
