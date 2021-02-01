namespace CSharpOop.TemperatureConverterTask
{
    class TemperatureConverter : IModel
    {
        public double Convert(IView view)
        {
            if (view.GetFromScale() == view.GetToScale())
            {
                return view.GetValueForConvert();
            }

            var temperatureInCelsius = view.GetFromScale().GetCelsiusFromScale(view.GetValueForConvert());

            return view.GetToScale().GetScaleFromCelsius(temperatureInCelsius);
        }
    }
}
