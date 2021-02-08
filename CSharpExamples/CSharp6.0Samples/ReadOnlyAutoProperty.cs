using System;
using System.Text;
namespace CSharp6._0Samples
{
    public class Mutation
    {
        /*Mutable and immutable are English words meaning "can change" and "cannot change" respectively. 
         * The meaning of the words is the same in the IT context; i.e.

        a mutable string can be changed, and
        an immutable string cannot be changed.
        The meanings of these words are the same in C# / .NET as in other programming languages / environments, though (obviously) the
        names of the types may differ, as may other details.

        For the record:

        string is the standard C# / .Net immutable string type
        StringBuilder is the standard C# / .Net mutable string type

        -----------------------------------------------------------
        every time you change string value it creates new instance of String class [variable] object and assign value to it.
        System.String str = "inital value";
        str = "\nsecond value";
        str = "\nthird value";

        StringBuilder sb = new StringBuilder();
        sb.Append("initial value");
        sb.AppendLine("second value");
        sb.AppendLine("third value");
        -----------------------------------------------------------

        Strings are mutable because .NET use string pool behind the scene. It means :

        string name = "My Country";
        string name2 = "My Country";
        Both name and name2 are referring to same memory location from string pool. Now suppose you want to change name2 to :

        name2 = "My Loving Country";
        It will look in to string pool for the string "My Loving Country", if found you will get the reference of it other wise
                new string "My Loving Country" will be created in string pool and name2 will get reference of it. But it this
                whole process "My Country" was not changed because other variable like name is still using it.
                And that is the reason why string are IMMUTABLE.

        StringBuilder works in different manner and don't use string pool. When we create any instance of StringBuilder :

        var address  = new StringBuilder(500);
        It allocate memory chunk of size 500 bytes for this instance and all operation just modify this memory location and this memory
                not shared with any other object. And that is the reason why StringBuilder is MUTABLE.
        */
        //Immutable string
        string fName = "Louis";
        //Mutable string
        StringBuilder name = new StringBuilder("Louis");
        //Change the value
        Mutation()
        {
            Console.WriteLine($"{fName}");
            Console.WriteLine($"{name}");
        }
    }
    //Step 1: Remove the setters of the class, only have getters.
    //Step 2: Provide parameters via constructor.
    //Step 3: Make the variables of the property READONLY
    // Immutable class creation example. All master data currency, country, region, Configuration Data, Singleton objects
    public class Currency
    {
        private readonly string _CurrencyName;

        public string CurrencyName
        {
            get { return _CurrencyName; }
        }
        private readonly string _CountryName;

        public string CountryName
        {
            get { return _CountryName; }
        }
        public Currency(string paramCurrencyName,
                        string paramCountryName)
        {
            _CurrencyName = paramCurrencyName;
            _CountryName = paramCountryName;
        }
    }
    public class ReadOnlyAutoProperty
    {
        //C#5.0 implementation of read-only properties of a class
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        //C#6.0 implementation of read-only auto properties of a class
        //Only syntax change for helping developers
        public string FirstName1 { get; }
        public string LastName1 { get; }

        public ReadOnlyAutoProperty(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }
    }
}
