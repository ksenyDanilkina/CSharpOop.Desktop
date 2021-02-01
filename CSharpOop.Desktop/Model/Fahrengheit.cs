namespace CSharpOop.TemperatureConverterTask
{
    class Fahrengheit : IBasicScale
    {
        public string Name => "Фаренгейт";

        public double GetCelsiusFromScale(double value)
        {
            return (value - 32) * 5 / 9;
        }

        public double GetScaleFromCelsius(double value)
        {
            return value * 1.8 + 32;
        }
    }
}
