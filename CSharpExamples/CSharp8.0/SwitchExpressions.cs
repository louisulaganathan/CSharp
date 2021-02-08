using System;
namespace CSharp8._0
{
    public class SwitchExpressions
    {
        public SwitchExpressions()
        {
        }
        public void SwitchExpressionDemo()
        {
            var country = "India";
            var result = country switch
            {
                "India" => "Vannakkam India",
                "USA"   => "Hello USA",
                _ => "Enter country",
            };
            Console.WriteLine($"Result: {result}");
        }

        public static void Main(string[] args)
        {
            SwitchExpressions demo = new SwitchExpressions();
            demo.SwitchExpressionDemo();
        }
    }
}
