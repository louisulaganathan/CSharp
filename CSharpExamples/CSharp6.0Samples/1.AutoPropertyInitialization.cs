using System;
namespace CSharp6._0Samples
{
    class AutoPropertyInitialization
    {
        public string FirstName { get; } = "Louis Raj";
        static void Main(string[] args)
        {
            var obj = new AutoPropertyInitialization();
            Console.WriteLine($"Hello {obj.FirstName}!");
        }

    }
}
