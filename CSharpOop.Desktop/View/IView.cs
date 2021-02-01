namespace CSharpOop.TemperatureConverterTask
{
    public interface IView
    {
        IBasicScale GetFromScale();

        IBasicScale GetToScale();

        double GetValueForConvert();
    }
}
