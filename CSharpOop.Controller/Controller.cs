using System;
using CSharpOop.TemperatureConverterTask;
namespace CSharpOop.Controller
{
    public class Controller
    {
        private readonly TemperatureConverter temperatureConverter;

        public Controller(TemperatureConverter temperatureConverter)
        {
            this.temperatureConverter = temperatureConverter;
        }

        public double ConvertTemperature(IView view)
        {
            return temperatureConverter.Convert(view.GetFromScale(), view.GetToScale(), view.GetValueForConvert());
        }
    }
}
