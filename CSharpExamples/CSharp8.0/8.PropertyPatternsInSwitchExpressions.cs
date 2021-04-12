using System;
namespace CSharp8._0
{

    /*********************************
     * The switch expression provides for switch-like semantics in an expression context. 
     * It provides a concise syntax when the switch arms produce a value.
     *********************************/
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
        public static decimal ComputeSalesTax1(Address location, decimal salePrice)
        {
            switch (location.State)
            {
                case "WA":
                    {
                        salePrice *= 0.06M;
                        break;
                    }
                default:
                    {
                        break;
                    }

            }
            return salePrice;
        }
        public static void Main(string[] args)
        {
            PropertyPatternsInSwitchExpressions demo = new PropertyPatternsInSwitchExpressions();
            demo.PropertyPatternDemo();
        }
    }
//  #Example 2
    public static class SwitchExample
    {
        public enum Directions
        {
            Up,
            Down,
            Right,
            Left
        }

        public enum Orientation
        {
            North,
            South,
            East,
            West
        }

        public static void Main()
        {
            var direction = Directions.Right;
            Console.WriteLine($"Map view direction is {direction}");

            var orientation = direction switch
            {
                Directions.Up => Orientation.North,
                Directions.Right => Orientation.East,
                Directions.Down => Orientation.South,
                Directions.Left => Orientation.West,
            };
            Console.WriteLine($"Cardinal orientation is {orientation}");
        }
    }
}
