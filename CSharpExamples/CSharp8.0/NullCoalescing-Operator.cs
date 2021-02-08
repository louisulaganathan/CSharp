using System;
using System.Collections.Generic;

namespace CSharp8._0
{
    public class NullCoalescing_Operator
    {
        /****************************************
         * C# 8.0 introduces the null-coalescing assignment operator ??=. 
         * You can use the ??= operator to assign the value of its right-hand operand to its left-hand operand only if the left-hand operand evaluates to null.
         ****************************************/
        public NullCoalescing_Operator()
        {
        }

        public void NullCoalescing_OperatorDemo()
        {
            List<int> numbers = null;
            int? i = null;

            numbers ??= new List<int>();
            numbers.Add(i ??= 17);
            numbers.Add(i ??= 20);  //add 17 second time to numbers list

            Console.WriteLine(string.Join(" ", numbers));  // output: 17 17
            Console.WriteLine(i);  // output: 17
        }

        public static void Main(string[] args)
        {
            NullCoalescing_Operator demo = new NullCoalescing_Operator();
            demo.NullCoalescing_OperatorDemo();
        }
    }
}
