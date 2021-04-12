using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp6._0Samples
{
    public class InitializeAssociateCollectionsUsingIndexersDemo
    {
        public InitializeAssociateCollectionsUsingIndexersDemo()
        {
        }

        public void InitializeCollectionsInCSharp5()
        {
            Dictionary<int, string> messages = new Dictionary<int, string>
            {
                { 404, "Page not Found"},
                { 302, "Page moved, but left a forwarding address."},
                { 500, "The web server can't come out to play today."}
            };
        }

        public void InitializeCollectionsInCSharp6()
        {
            Dictionary<int, string> messages = new Dictionary<int, string>
            {
                [404] = "Page not Found",
                [302] = "Page moved, but left a forwarding address.",
                [500] = "The web server can't come out to play today."
            };
        }

        static Task DoThings()
        {
            return Task.FromResult(0);
        }
        //The earlier compiler couldn't distinguish correctly between Task.Run(Action) and Task.Run(Func<Task>()).
        //In previous versions, you'd need to use a lambda expression as an argument as below
        public void TaskRunSyntaxInCShart5()
        {
            Task.Run(()=> DoThings());
        }
        //The C# 6 compiler correctly determines that Task.Run(Func<Task>()) is a better choice.
        public void TaskRunSyntaxInCShart6()
        {
            Task.Run(DoThings);
        }

        public static void Main(string[] args)
        {

        }
    }
}
