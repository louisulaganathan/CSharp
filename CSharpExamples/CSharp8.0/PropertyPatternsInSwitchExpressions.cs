using System;
namespace CSharp8._0
{
    public class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
    public class PropertyPatternsInSwitchExpressions
    {
        public PropertyPatternsInSwitchExpressions()
        {
        }
        public void PropertyPatternDemo()
        {
            var result = ComputeSalesTax(new Address() { AddressLine1 = "2600 scofield ridge pkwy", AddressLine2 = "Apt 614", City = "Austin", State = "TX", Zip = "78727" }, (decimal)100.00);
            Console.WriteLine($"Sales Tax : {result}");
        }
        public static decimal ComputeSalesTax(Address location, decimal salePrice) =>
    location switch
    {
        { State: "WA" } => salePrice * 0.06M,
        { State: "MN" } => salePrice * 0.075M,
        { State: "MI" } => salePrice * 0.05M,
        { State: "TX" } => salePrice * 0,
        // other cases removed for brevity...
        _ => 0M
    };
        public static void Main(string[] args)
        {
            PropertyPatternsInSwitchExpressions demo = new PropertyPatternsInSwitchExpressions();
            demo.PropertyPatternDemo();
        }
    }
}
