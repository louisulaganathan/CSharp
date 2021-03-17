using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp
{
    /*
     * Many designs for classes include methods that are called from only one location. 
     * These additional private methods[local functions] keep each method small and focused. 
     * Local functions enable you to declare methods inside the context of another method. 
     * Local functions make it easier for readers of the class to see that the local method is only called from the context in which it is declared.
     * 
     * There are two common use cases for local functions: 
     *      public iterator methods
     *      public async methods. 
     * Both types of methods generate code that reports errors later than programmers might expect. In iterator methods, any exceptions are observed only when calling code that enumerates the returned sequence. In async methods, any exceptions are only observed when the returned Task is awaited. 
     * 
     * The following example demonstrates separating parameter validation from the iterator implementation using a local function:

     * */
    public class LocalFunctionsDemo
    {
        public LocalFunctionsDemo()
        {
        }
        //Public iterator
        public static IEnumerable<char> AlphabetSubset3(char start, char end)
        {
            if (start < 'a' || start > 'z')
                throw new ArgumentOutOfRangeException(paramName: nameof(start), message: "start must be a letter");
            if (end < 'a' || end > 'z')
                throw new ArgumentOutOfRangeException(paramName: nameof(end), message: "end must be a letter");

            if (end <= start)
                throw new ArgumentException($"{nameof(end)} must be greater than {nameof(start)}");

            return alphabetSubsetImplementation();

            IEnumerable<char> alphabetSubsetImplementation()
            {
                for (var c = start; c < end; c++)
                    yield return c;
            }
        }
        //Public Async
        /*
         * The same technique can be employed with async methods to ensure that exceptions arising from argument validation are thrown before the asynchronous work begins:
         */
        public Task<string> PerformLongRunningWork(string address, int index, string name)
        {
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException(message: "An address is required", paramName: nameof(address));
            if (index < 0)
                throw new ArgumentOutOfRangeException(paramName: nameof(index), message: "The index must be non-negative");
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(message: "You must supply a name", paramName: nameof(name));

            return longRunningWorkImplementation();
            //Actually Async process starts here
            async Task<string> longRunningWorkImplementation()
            {
                var interimResult = FirstWork(address);
                var secondResult = SecondStep(index, name);
                return $"The results are {interimResult} and {secondResult}. Enjoy.";
            }

            string FirstWork(string street)
            {
                return street;
            }
            string SecondStep(int index1, string name1)
            {
                return name1;
            }
        }
    }
}
