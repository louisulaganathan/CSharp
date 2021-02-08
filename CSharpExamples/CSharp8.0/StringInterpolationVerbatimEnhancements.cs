using System;
namespace CSharp8._0
{
    public class StringInterpolationVerbatimEnhancements
    {
        /*******************************************
         * @ charactor usage 
         * 1. To enable C# keywords to be used as identifiers. The @ character prefixes a code element that the compiler is to interpret as an identifier rather than a C# keyword
         * 
         * 
         * 2. To indicate that a string literal is to be interpreted verbatim. The @ character in this instance defines a verbatim string literal. Simple escape sequences (such as "\\" for a backslash)
         * 
         * Interpolation enhancements
         * Starting with C# 8.0, you can use the $ and @ tokens in any order: both $@"..." and @$"..." are valid interpolated verbatim strings. 
         * In earlier C# versions, the $ token must appear before the @ token.
         * 
         * 
         *******************************************/
        public StringInterpolationVerbatimEnhancements()
        {
        }

        public void AtTheRateCharactorUsage()
        {
            //**************Type 1: ******************
            //Compiler will not throw error for using for c# keyword as Identifier/variable name
            string[] @for = { "John", "James", "Joan", "Jamie" };
            for (int ctr = 0; ctr < @for.Length; ctr++)
            {
                Console.WriteLine($"Here is your gift, {@for[ctr]}!");
            }
            // The example displays the following output:
            //     Here is your gift, John!
            //     Here is your gift, James!
            //     Here is your gift, Joan!
            //     Here is your gift, Jamie!

            //***********Type 2: *********************
            string filename1 = @"c:\documents\files\u0066.txt";
            string filename2 = "c:\\documents\\files\\u0066.txt";

            Console.WriteLine(filename1);
            Console.WriteLine(filename2);
            // The example displays the following output:
            //     c:\documents\files\u0066.txt
            //     c:\documents\files\u0066.txt


        }

        public void IntepolationEnhancements()
        {
            /*********************************
             * The $ special character identifies a string literal as an interpolated string. 
             * An interpolated string is a string literal that might contain interpolation expressions
             * This feature is available starting with C# 6.
             **********************************/
            string name = "Mark";
            var date = DateTime.Now;

            // Composite formatting:
            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
            // String interpolation:
            Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
            // Both calls produce the same output that is similar to:
            // Hello, Mark! Today is Wednesday, it's 19:40 now.
        }
    }
}
