namespace CSharpOop.TemperatureConverterTask
{
    class Celsius : IBasicScale
    {
        public string Name => "Цельсий";

        public double GetCelsiusFromScale(double value)
        {
            return value;
        }

        public double GetScaleFromCelsius(double value)
        {
            return value;
        }      
    }
}
