public enum TemperatureScalesKind
{
    Celsius,
    Fahrenheit,
    Kelvin
}

namespace Gloomath.Models.ThermodynamicCalculator
{
    public class Temperature
    {
        public double Value { get; set; }
        public TemperatureScalesKind Scale { get; set; }
    }
}
