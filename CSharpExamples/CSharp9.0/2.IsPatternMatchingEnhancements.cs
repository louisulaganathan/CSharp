using System;
namespace CSharp9._0
{
    public class IsPatternMatchingEnhancements
    {
        /************************************
         * C# 9 includes new pattern matching improvements:
         * Type patterns match a variable "is" a type
         * Parenthesized patterns enforce or emphasize the precedence of pattern combinations
         * Conjunctive and patterns require both patterns to match
         * Disjunctive or patterns require either pattern to match
         * Negated not patterns require that a pattern doesn’t match
         * Relational patterns require the input be less than, greater than, less than or equal, or greater than or equal to a given constant.
         * 
         * 
         * 
         * ***********************************/
        public IsPatternMatchingEnhancements()
        {
        }

        public void IsPatternMatchingEnhancementsDemo()
        {
            char? e = null;
            if (e is not null)
            {
                Console.WriteLine($"Char e is not null");
            }
            if (e is null)
            {
                Console.WriteLine($"Char e is null");
            }
            char ch = 'd';
            Console.WriteLine($"ch.IsLetter(): {ch.IsLetter()}");
            ch = '.';
            Console.WriteLine($"ch.IsLetter(): {ch.IsLetterOrSeparator()}");
        }



    }

    public static class ExtensionClass
    {
        public static bool IsLetter(this char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
        public static bool IsLetterOrSeparator(this char c) => c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';
    }
}
