using System;
namespace CSharp9._0
{
    /*******************************************
     * .Net core3.X doesn't provide C#9.0 language support. C# 9.0 language support is provided in .Net5 only
     * 
     * C# language versioning against framework support
     * *************************************************
     * 
The rules in this article apply to the compiler delivered with Visual Studio 2019 or the .NET SDK.
The C# compilers that are part of the Visual Studio 2017 installation or earlier .NET Core SDK versions target C# 7.0 by default.

C# 8.0 is supported only on .NET Core 3.x and newer versions. Many of the newest features require library and runtime features introduced in .NET Core 3.x:

Default interface implementation requires new features in the .NET Core 3.0 CLR.
Async streams require the new types System.IAsyncDisposable, System.Collections.Generic.IAsyncEnumerable<T>, and System.Collections.Generic.IAsyncEnumerator<T>.
Indices and ranges require the new types System.Index and System.Range.
Nullable reference types make use of several attributes to provide better warnings. Those attributes were added in .NET Core 3.0. Other target frameworks haven't been annotated with any of these attributes. That means nullable warnings may not accurately reflect potential issues.

C# 9.0 is supported only on .NET 5 and newer versions.
     * 
     * 
     * *****************************************
     * *****************************************
     * C# 9.0 introduces record types, which are a reference type that provides synthesized methods to provide value semantics for equality. 
     * Records are IMMUTABLE by default.
     * Record types make it easy to create immutable reference types in .NET
     * Records support inheritance. 
     * 
     * <C#9.0 immutable class example
     * class ImmutableRefClass
     * {
     *  private readonly string property1;
     *  private readonly string property2;
     *  public ImmutableRefClass(string prop1,string prop2)
     *  {
     *  this.property1 = prop1;
     *  this.property2 = prop2;
     *  }
     *  
     *  //  OR
     *  public string Property1 { get; } = "value1";
     * }
     * 
     * *****************************************/

    public class RecordReferenceType
    {
        public RecordReferenceType()
        {
        }

        public void RecordReferenceTypeDemo()
        {
            Person obj = new Person("Louis Raj", "Ulaganathan");
            Console.WriteLine($"First Name : {obj.FirstName}/n");
            Console.WriteLine($"Last Name : {obj.LasName}");
        }

        public record Person
        {
            public string FirstName { get; }
            public string LasName { get;  }

            public Person(string fName, string lName) => (FirstName, LasName) = (fName, lName);
        }

        public record Teacher : Person  //if you decarate using sealed then we can stop further derive this class
        {
            public string Subject { get; }

            public Teacher(string first, string last, string sub)
                : base(first, last) => Subject = sub;
        }
        public static void Main(string[] args)
        {
            RecordReferenceType demo = new RecordReferenceType();
            demo.RecordReferenceTypeDemo();
        }
    }
}
