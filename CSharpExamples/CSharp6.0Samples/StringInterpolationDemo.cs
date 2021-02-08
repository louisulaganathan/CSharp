using System;
namespace CSharp6._0Samples
{
    //String Interpolation syntax is $"Sample Text {{expression}} 
    public class StringInterpolationDemo
    {
        string firstName = "Louis Raj";
        string lastName = "Ulaganathan";

        public StringInterpolationDemo()
        {
        }

        public void DisplayText()
        {
            Console.WriteLine($"String Interpolation syntax is $\"Text {{expression}}\" example Text: Name { firstName},{lastName}");
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

        public static void Main(string[] args)
        {
            StringInterpolationDemo demo = new StringInterpolationDemo();
            demo.DisplayText();

        }
    }
}
