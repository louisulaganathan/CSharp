using System;
namespace CSharp
{
    // A discard variable is a write only variable whose name is _
    // A discard is like an unassigned variable; apart from the assignment statement, the discard can't be used in code.
    // When deconstructing tuples or user-defined types.
    // When calling methods with out parameters.
    // In a pattern matching operation with the is and switch statements.
    public class DiscardVariableDemo
    {
        public DiscardVariableDemo()
        {
        }

        public void DisplayDiscardVariableSyntax()
        {
            var (_, _, _, pop1, _, pop2) = QueryCityDataForYears("New York City", 1960, 2010);

            Console.WriteLine($"Population change, 1960 to 2010: {pop2 - pop1:N0}");
        }

        private static (string, double, int, int, int, int) QueryCityDataForYears(string name, int year1, int year2)
        {
            int population1 = 0, population2 = 0;
            double area = 0;

            if (name == "New York City")
            {
                area = 468.48;
                if (year1 == 1960)
                {
                    population1 = 7781984;
                }
                if (year2 == 2010)
                {
                    population2 = 8175133;
                }
                return (name, area, year1, population1, year2, population2);
            }

            return ("", 0, 0, 0, 0, 0);
        }

        public static void Main(string[] args)
        {
            DiscardVariableDemo demo = new DiscardVariableDemo();
            demo.DisplayDiscardVariableSyntax();
        }
    }
}
