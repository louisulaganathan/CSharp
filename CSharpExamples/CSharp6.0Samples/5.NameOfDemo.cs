using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CSharp6._0Samples
{
    //This feature is most useful when you need to convert a parameter or property name to a string
    public class NameOfDemo
    {
        public NameOfDemo()
        {
        }
        private string _firstName;
        [DisplayName("FirstNameDisplayName")]
        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }

        public void DisplayNameOfDemo()
        {
            Console.WriteLine(nameof(System.String));
            int j = 5;
            Console.WriteLine(nameof(j));
            List<string> names = new List<string>();
            Console.WriteLine(nameof(names));
            Console.WriteLine(nameof(this.FirstName));
            Console.WriteLine(nameof(_firstName));
        }

        public static void Main(string[] arg)
        {
            NameOfDemo demo = new NameOfDemo();
            demo.DisplayNameOfDemo();
        }
    }
}
