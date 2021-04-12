using System;
namespace CSharp9._0
{
    public class NewObjectCreationFitAndFinishFeature
    {
        /************************************
         * In C# 9.0, you can omit the type in a new expression when the created object's type is already known. 
         * The most common use is in field declarations:
         * Target-typed new can also be used when you need to create a new object to pass as an argument to a method. 

         * Starting in C# 9.0, you can add the static modifier to lambda expressions or anonymous methods. 
         * Static lambda expressions are analogous to the static local functions: a static lambda or anonymous method can't capture local variables or instance state. 
         * The static modifier prevents accidentally capturing other variables.
         * ***********************************/
        public class Person
        {
            public string Name { get; set; }
        }
        public NewObjectCreationFitAndFinishFeature()
        {
        }
        public void NewObjectCreationFitAndFinishFeatureDemo(Person person)
        {

        }

        public static void Main(string[] args)
        {
            NewObjectCreationFitAndFinishFeature demo1 = new NewObjectCreationFitAndFinishFeature();  //<C#9.0
            NewObjectCreationFitAndFinishFeature demo = new();  //C# 9.0
            demo.NewObjectCreationFitAndFinishFeatureDemo(new()); //C# 9.0

            Person station = new() { Name = "Seattle, WA" };//C# 9.0

        }
    }
}
