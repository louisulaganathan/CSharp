using System;
namespace CSharp8._0
{
    public class IndicesAndRanges
    {
        /*******************************************
        This language support relies on two new types, and two new operators:

        System.Index represents an index into a sequence.
            The index from end operator ^, which specifies that an index is relative to the end of the sequence.
        System.Range represents a sub range of a sequence.
            The range operator .., which specifies the start and end of a range as its operands.
        Let's start with the rules for indexes. Consider an array sequence.
        The 0 index is the same as sequence[0].
        The ^0 index is the same as sequence[sequence.Length].
        Note that sequence[^0] does throw an exception, just as sequence[sequence.Length] does.
        For any number n, the index ^n is the same as sequence.Length - n.

        A range specifies the start and end of a range.
        The start of the range is inclusive, but the end of the range is exclusive, meaning the start is included in the range but the end isn't included in the range.
        The range [0..^0] represents the entire range, just as [0..sequence.Length] represents the entire range.
        *********************************************/
        public IndicesAndRanges()
        {
        }

        public void IndexAndRangeDemo()
        {
            var words = new string[]
            {
                            // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };              // 9 (or words.Length) ^0

            Console.WriteLine($"words[^1]: {words[^1]}");
            // writes "dog"
            var quickBrownFox = words[1..4];
            var lazyDog = words[^2..^0];
            var allWords = words[..]; // contains "The" through "dog".
            var firstPhrase = words[..4]; // contains "The" through "fox"
            var lastPhrase = words[6..]; // contains "the", "lazy" and "dog"
            Range phrase = 1..4;
            var text = words[phrase];
            Console.WriteLine($"words[1..4] : {string.Concat(quickBrownFox)}");
            Console.WriteLine($"words[^2..^0] : {string.Concat(lazyDog)}");
            Console.WriteLine($"words[..] : {string.Concat(allWords)}");
            Console.WriteLine($"words[..4] : {string.Concat(firstPhrase)}");
            Console.WriteLine($"words[6..] : {string.Concat(lastPhrase)}");
        }

        public static void Main(string[] args)
        {
            IndicesAndRanges demo = new IndicesAndRanges();
            demo.IndexAndRangeDemo();
        }
    }
}
