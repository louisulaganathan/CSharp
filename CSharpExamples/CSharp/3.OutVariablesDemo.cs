using System;
namespace CSharp
{
    public class OutVariablesDemo
    {
        //Both Ref & Out will work with value types and reference types-object
        public OutVariablesDemo()
        {

        }
        //Ref it is not require to initialize the variable inside method
        //It's important to note that in, out, and ref cannot be used in methods with the async modifier.
        //You can use them in synchronous methods that return a Task, though
        public void DisplayOutVariableRef()
        {
            int value = 5;
            IncrementRef(ref value);
            Console.WriteLine($"Ref Variable Value : {value}");

        }
        public void IncrementRef(ref int input)
        {
            input++;
        }
        //When using out, you must initialize the parameter you pass inside the method.Otherwise it will throw error in method
        public void DisplayOutVariableOut()
        {
            //The below syntax works for previous versions of c#
            //int value = 5;
            //IncrementOut(out value);

            // The below will work only c# > 7, The same in 6.0 throws
            //"Error CS8059: Feature 'out variable declaration' is not available in C# 6. Please use language version 7.0 or greater."
            IncrementOut(out var value);
            Console.WriteLine($"Out Variable Value : {value}");
            
        }
        public void IncrementOut(out int input)
        {
            //input++; //Error out since input is not initialized
            input = 10;

        }

        public static void Main(string[] args)
        {
            OutVariablesDemo demo = new OutVariablesDemo();
            demo.DisplayOutVariableRef();
            demo.DisplayOutVariableOut();
        }

        //in modifier
        //introduced in C# 7.2. The motivation of in is to be used with a struct to improve performance by declaring that the value will not be modified.
        //When useding with reference type,s it only prevents you from assigning a new reference.
        class ReferenceTypeExample
        {
            static void Enroll(in Student1 student)
            {
                // With in assigning a new object would throw an error
                // student = new Student();

                // We can still do this with reference types though
                student.Enrolled = true;
            }

            static void Main()
            {
                var student = new Student1
                {
                    Name = "Susan",
                    Enrolled = false
                };

                Enroll(student);
            }
        }
        public class Student1
        {
            public string Name { get; set; }
            public bool Enrolled { get; set; }
        }
    }
}
