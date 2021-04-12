using System;
namespace CSharp6._0Samples
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    //Null conditional operators ?? & ?.
    //Replace the member access . with ?.
    public class NullConditionalOperatorDemo
    {
        Person person = null;
        public NullConditionalOperatorDemo()
        {
        }

        public void MemberAccess()
        {
            //Person object null scenario
            var text = person?.FirstName;
            Console.WriteLine($"person?.FirstName Text : {text}");
            text = person?.FirstName??"Not Specified";
            //Below line will write empty[null] only because ?. will fail and text will be assigned with person null value
            Console.WriteLine($"person?.FirstName??'Not Specified' Text : {text}");
            //Person object not null scenario
            Console.WriteLine("*****person = new Person();******");
            person = new Person();
            //First name is empty value is null
            text = person?.FirstName;
            Console.WriteLine($"person?.FirstName Text : {text}");
            text = person?.FirstName ?? "Not Specified";
            Console.WriteLine($"person?.FirstName??'Not Specified' Text : {text}");
            Console.WriteLine("*****person = new Person(){...};******");
            person = new Person() { FirstName="Louis Raj", LastName="Ulaganathan" };
            text = person?.FirstName;
            Console.WriteLine($"person?.FirstName Text : {text}");
            text = person?.FirstName ?? "Not Specified";
            Console.WriteLine($"person?.FirstName??'Not Specified' Text : {text}");
            Console.WriteLine("*****person = new Person(){...};******");
            //First name is empty value but not null
            person = new Person() { FirstName = " ", LastName = "Ulaganathan" };
            text = person?.FirstName;
            Console.WriteLine($"person?.FirstName Text : {text}");
            text = person?.FirstName ?? "Not Specified";
            Console.WriteLine($"person?.FirstName??'Not Specified' Text : {text}");
        }

        public static void Main(string[] args)
        {
            NullConditionalOperatorDemo demo = new NullConditionalOperatorDemo();
            demo.MemberAccess();
        }
    }
}
