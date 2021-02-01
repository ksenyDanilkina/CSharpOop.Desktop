namespace CSharpOop.TemperatureConverterTask
{
    public interface IBasicScale
    {
        double GetCelsiusFromScale(double value);

        double GetScaleFromCelsius(double value);
    }
}
