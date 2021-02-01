namespace CSharpOop.TemperatureConverterTask
{
    public class Controller : IController
    {
        private readonly IModel model;

        public Controller(IModel model)
        {
            this.model = model;
        }

        public double ConvertTemperature(IView view)
        {
            return model.Convert(view);
        }
    }
}
