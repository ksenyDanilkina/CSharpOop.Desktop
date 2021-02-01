namespace CSharpOop.TemperatureConverterTask
{
    class Kelvin : IBasicScale
    {
        public string Name => "Кельвин";

        public double GetCelsiusFromScale(double value)
        {
            return value - 273.15;
        }

        public double GetScaleFromCelsius(double value)
        {
            return value + 273.15;
        }
    }
}
