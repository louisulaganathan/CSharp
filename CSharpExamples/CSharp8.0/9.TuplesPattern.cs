using System;
using static System.Console;
namespace CSharp8._0
{
    public class TuplesPattern
    {
        public TuplesPattern()
        {
        }
        public void TuplesPatternDemo()
        {
            var result = RockPaperScissors("paper", "scissors");
            WriteLine($"Result: {result}");

        }
        //Expression bodied member function
        public static string RockPaperScissors(string first, string second)
    => (first, second) switch
    {
        ("rock", "paper") => "rock is covered by paper. Paper wins.",
        ("rock", "scissors") => "rock breaks scissors. Rock wins.",
        ("paper", "rock") => "paper covers rock. Paper wins.",
        ("paper", "scissors") => "paper is cut by scissors. Scissors wins.",
        ("scissors", "rock") => "scissors is broken by rock. Rock wins.",
        ("scissors", "paper") => "scissors cuts paper. Scissors wins.",
        (_, _) => "tie"
    };
        public static void Main(string[] args)
        {
            TuplesPattern demo = new TuplesPattern();
            demo.TuplesPatternDemo();
        }
    }
}
