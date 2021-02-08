using System;
namespace CSharp
{
    //Tuples[light weight data structures] are available in earlier version of C# but it can be accessed using Tuple.Item1, Tuple.Item2, etc and
    //created using Tuple<string,string> obj= new Tuple<string,string();
    public class LanguageSupportForTuples
    {
        public LanguageSupportForTuples()
        {
        }
        //Language support :- provid naming of tuple property
        public void DisplayTupleSyntax()
        {
            //Tuples are declared as below from C# 7.0 with name language support
            (string fName, string lName) name = ("Louis Raj", "Ulaganathan");
            Console.WriteLine($"First Name: {name.fName}, Last Name: {name.lName}");
            var numbers = (max:10, min:5);
            Console.WriteLine($"Numbers max: {numbers.max}, min: {numbers.min}");
        }

        public static void Main(string[] args)
        {
            LanguageSupportForTuples demo = new LanguageSupportForTuples();
            demo.DisplayTupleSyntax();
        }
    }
}
