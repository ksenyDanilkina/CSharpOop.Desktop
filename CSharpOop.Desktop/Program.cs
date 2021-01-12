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
            
            TemperatureConverter temperatureConverter = new TemperatureConverter();
            Controller controller = new Controller(temperatureConverter);
                       
            Application.Run(new TemperatureConverterView(controller));
        }
    }
}
