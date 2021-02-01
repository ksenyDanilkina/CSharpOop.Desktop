using System;
using System.Windows.Forms;

namespace CSharpOop.TemperatureConverterTask
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var model = new TemperatureConverter();
            var controller = new Controller(model);

            var scales = new IBasicScale[] { new Kelvin(), new Fahrengheit(), new Celsius() };

            Application.Run(new TemperatureConverterView(controller, scales));
        }
    }
}
