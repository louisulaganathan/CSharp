using System;
namespace CSharp9._0
{
    public class InitOnlySetters
    {
        public class WeatherObservation
        {
            public DateTime RecordedAt { get; init; }
            public decimal TemperatureInCelsius { get; init; }
            public decimal PressureInMillibars { get; init; }

            public override string ToString() =>
                $"At {RecordedAt:h:mm tt} on {RecordedAt:M/d/yyyy}: " +
                $"Temp = {TemperatureInCelsius}, with {PressureInMillibars} pressure";
        }
        public InitOnlySetters()
        {
        }

        public void InitOnlySettersDemo()
        {
            WeatherObservation obj = new WeatherObservation
            {
                RecordedAt = DateTime.Now,
                TemperatureInCelsius = 20,
                PressureInMillibars = 998.0m
            };
            // Error! CS8852. changing an observation after initialization is an error by assigning to an init-only property outside of initialization:
            //obj.TemperatureInCelsius = 18;
            obj.ToString();
        }

        public static void Main(string[] args)
        {
            InitOnlySetters demo = new InitOnlySetters();
            demo.InitOnlySettersDemo();
        }
    }
}
