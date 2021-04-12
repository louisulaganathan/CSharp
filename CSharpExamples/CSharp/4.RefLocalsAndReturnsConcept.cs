using System;
namespace CSharp
{

    //Ref usage in local functions & return statements
    public class RefLocalsAndReturnsConcept
    {
        public RefLocalsAndReturnsConcept()
        {
        }
        //This feature enables algorithms that use and return references to variables defined elsewhere.
        //One example is working with large matrices, and finding a single location with certain characteristics.
        //The following method returns a reference to that storage in the matrix:
        public static ref int Find(int[,] matrix, Func<int, bool> predicate) //ref in local function
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (predicate(matrix[i, j]))
                        return ref matrix[i, j];  //returning reference of an variable
            throw new InvalidOperationException("Not found");
        }
        //You can declare the return value as a ref and modify that value in the matrix, as shown in the following code:
        public static void Main(string[] args)
        {
            int[,] matrix = new int[2,2]{ { 0, 1 },{ 42, 24 }};
            ref var item = ref RefLocalsAndReturnsConcept.Find(matrix, (val) => val == 42);
            Console.WriteLine($"Old Value: {item}");
            item = 24;
            Console.WriteLine($"New Value: {matrix[1, 0]}");
        }

        /*
         * The C# language has several rules that protect you from misusing the ref locals and returns:

You must add the ref keyword to the method signature and to all return statements in a method.
That makes it clear the method returns by reference throughout the method.
A ref return may be assigned to a value variable, or a ref variable.
The caller controls whether the return value is copied or not. Omitting the ref modifier when assigning the return value indicates that the caller wants a copy of the value,
not a reference to the storage.
You can't assign a standard method return value to a ref local variable.
That disallows statements like ref int i = sequence.Count();
You can't return a ref to a variable whose lifetime doesn't extend beyond the execution of the method.
That means you can't return a reference to a local variable or a variable with a similar scope.
ref locals and returns can't be used with async methods.
The compiler can't know if the referenced variable has been set to its final value when the async method returns.
The addition of ref locals and ref returns enables algorithms that are more efficient by avoiding copying values, or performing dereferencing operations multiple times.

Adding ref to the return value is a source compatible change. Existing code compiles, but the ref return value is copied when assigned.
        Callers must update the storage for the return value to a ref local variable to store the return as a reference.
         */
    }
}
