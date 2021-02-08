using System;
using System.Threading.Tasks;
namespace CSharp
{
    /* IMPORTANT
     * Returning a Task object from async methods can introduce performance bottlenecks in certain paths. 
     * Task is a reference type, so using it means allocating an object. 
     * In cases where a method declared with the async modifier returns a cached result, or completes synchronously, 
     * the extra allocations can become a significant time cost in performance critical sections of code. It can become costly if those allocations occur in tight loops.
     * The new language feature means that async method return types aren't limited to Task, Task<T>, and void. 
     * The returned type must still satisfy the async pattern, meaning a GetAwaiter method must be accessible. As one concrete example, 
     * the ValueTask type has been added to .NET to make use of this new language feature:
     */
    public class AsyncReturnTypeConcept
    {
        public AsyncReturnTypeConcept()
        {
        }
        //IMP:
        //You need to add the NuGet package System.Threading.Tasks.Extensions in order to use the ValueTask<TResult> type. Otherwise ValueTask will throw error.
        public async ValueTask<int> Func()
        {
            await Task.Delay(100);
            return 5;
        }
    }
}
