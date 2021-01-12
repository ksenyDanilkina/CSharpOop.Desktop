namespace CSharpOop.TemperatureConverterTask
{
    public interface IView
    {
        string GetFromScale();

        string GetToScale();

        double GetValueForConvert();
    }
}
