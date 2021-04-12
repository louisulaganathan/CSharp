//using System;
//Below are the using static syntax 
using static System.Math;
using static System.String;
using static System.Console;
namespace CSharp6._0Samples
{
    public static class UsingStaticDemo
    {
        public static int ToString(this string str, string text)
        {
            return 0;
        }
    }
    public class UsingStaticDemo2
    {
        public UsingStaticDemo2()
        {

        }
        public void DisplayText(string name)
        {
            bool value = name.Equals("Louis");
            //Console.WriteLine($"{name}, {name.Equals("Louis")}");//This line is needed if I Import using System
            WriteLine($"{name}, {name.Equals("Louis")}"); //This line is used if I use using static System.Console. No need to use static class name.Null
        }
        public static void Main(string[] args)
        {
            UsingStaticDemo2 obj = new UsingStaticDemo2();
            obj.DisplayText("Louis");
        }
    }
}
