using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp8._0
{
    public class AsynchronousStreams
    {
//Starting with C# 8.0, you can create and consume streams asynchronously. A method that returns an asynchronous stream has three properties:

//      It's declared with the async modifier.
//      It returns an IAsyncEnumerable<T>.
//      The method contains yield return statements to return successive elements in the asynchronous stream.
//Consuming an asynchronous stream requires you to add the await keyword before the foreach keyword when you enumerate the elements of the stream.
//Adding the await keyword requires the method that enumerates the asynchronous stream to be declared with the async modifier and to return a type allowed for an async method.
//Typically that means returning a Task or Task<TResult>. It can also be a ValueTask or ValueTask<TResult>. A method can both consume and produce an asynchronous stream,
//which means it would return an IAsyncEnumerable<T>. The following code generates a sequence from 0 to 19, waiting 100 ms between generating each number:
        public AsynchronousStreams()
        {
        }

        public static async IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(1000);
                yield return i;
            }
        }

        public async void AsynchronousStreamDemo()
        {
            await foreach (var number in GenerateSequence())
            {
                Console.WriteLine(number);
            }

            //Invalid syntax throws error in compile time itself
            //var numbers = await GenerateSequence();
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
        }

        public static void Main(string[] args)
        {
            AsynchronousStreams obj = new AsynchronousStreams();
            obj.AsynchronousStreamDemo();
            Console.ReadKey();
        }
    }
}
