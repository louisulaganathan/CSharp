using System;
using static System.Console;
namespace CSharp8._0
{
    public class StaticLocalFunctions
    {
        public StaticLocalFunctions()
        {
        }
        //Non static local functions which consumes/reference variables from enclosing scope
        int NonStaticLocalFunction()
        {
            int y = 5;
            int x = 7;
            int z = 0;
            LocalFunction();
            return z;
            int LocalFunction() => z = x + y;
        }
        //Static Local Functions which can't reference variable from enclosing scope
        int StaticLocalFunction()
        {
            int y = 5;
            int x = 7;
            int z = 0;
            LocalFunction(x, y);
            return z;

            static int LocalFunction(int left, int right) => left + right;
        }

        public void StaticLocalFunctionDemo()
        {
            var nonStaticResults = NonStaticLocalFunction();
            var staticResults = StaticLocalFunction();
            WriteLine($"Non Static Value changed to {nonStaticResults}\nStatic Local Function value remain unaffected {staticResults} ");
        }

        public static void Main(string[] args)
        {
            StaticLocalFunctions demo = new StaticLocalFunctions();
            demo.StaticLocalFunctionDemo();
        }
    }
}
