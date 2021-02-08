using System;
namespace CSharp
{
    public class ThrowsExpressionSampleClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ThrowsExpressionSampleClass(string fName, string lName)
        {
            // C#6.0 version
            //if(fName!= null)
            //{
            //    FirstName = fName;
            //} else
            //{
            //    throw new ArgumentNullException(paramName: nameof(FirstName));
            //}
            //if (lName != null)
            //{
            //    LastName = lName;
            //}
            //else
            //{
            //    throw new ArgumentNullException(paramName: nameof(LastName));
            //}

            // C#7.0 version

            FirstName = fName?? throw new ArgumentNullException(paramName: nameof(FirstName));
            LastName = lName ?? throw new ArgumentNullException(paramName: nameof(LastName));
        }
        public void DisplayName()
        {
            Console.WriteLine($"First Name : {FirstName} & Last Name : {LastName}");
        }

        //C# 7.0 Feature: ThrowsExpression : Throws exception from expression
        public static void Main(string[] args)
        {
            ThrowsExpressionSampleClass throwsExpression = new ThrowsExpressionSampleClass("Louis Raj", "Ulaganathan");
            throwsExpression.DisplayName();
            throwsExpression = new ThrowsExpressionSampleClass("Louis Raj", null);
            throwsExpression.DisplayName();
        }
    }
}
