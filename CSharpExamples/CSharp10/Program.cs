using System.Linq;
using System.Text;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace CSharp10._0
{
    [MemoryDiagnoser]
    public class Program
    {
        [Benchmark]
        public void ForEach()
        {
            List<string> names = new List<string>() { "louis", "raj" };
            StringBuilder sb = new StringBuilder();
            char delimitter = ',';
            names.ForEach(name => sb.Append($"{name}{delimitter}"));
            Console.WriteLine(sb.ToString().TrimEnd(delimitter));
        }

        [Benchmark]
        public void Linq()
        {
            List<string> names = new List<string>() { "louis", "raj" };
            var envs = string.Join(',', names.Select(env => env).ToList());
            Console.WriteLine(envs);
        }
        public static void Main(string[] args)
        {


            var summary = BenchmarkRunner.Run<Demo>();
            //Demo d = new();
            //d.ForEach();
            //d.Linq();

        }

        [MemoryDiagnoser]
        public class Demo
        {
            [Benchmark]
            public void ForEach()
            {
                List<string> names = new List<string>() { "louis", "raj" };
                StringBuilder sb = new StringBuilder();
                char delimitter = ',';
                names.ForEach(name => sb.Append($"{name}{delimitter}"));
                Console.WriteLine(sb.ToString().TrimEnd(delimitter));
            }

            [Benchmark]
            public void Linq()
            {
                List<string> names = new List<string>() { "louis", "raj" };
                var envs = string.Join(',', names.Select(env => env).ToList());
                Console.WriteLine(envs);
            }
        }
    }
}