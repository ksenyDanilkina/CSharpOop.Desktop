using System;
using System.Windows.Forms;

namespace CSharpOop.TemperatureConverterTask
{
    public partial class TemperatureConverterView : Form, IView
    {
        private readonly Controller controller;

        public TemperatureConverterView(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Выберите шкалу из которой нужно перевести.", "Ошибка");
            }
            else if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Выберите шкалу в которую нужно перевести.", "Ошибка");
            }
            else if (!double.TryParse(maskedTextBox1.Text, out var result))
            {
                MessageBox.Show("Неверный формат данных. Проверьте правильность введенного значения температуры.", "Ошибка");
            }
            else
            {
                textBox2.Text = controller.ConvertTemperature(this).ToString();
            }
        }

        public string GetFromScale()
        {
            return comboBox1.SelectedItem.ToString();
        }

        public string GetToScale()
        {
            return comboBox2.SelectedItem.ToString();
        }

        public double GetValueForConvert()
        {
            return double.Parse(maskedTextBox1.Text);
        }
    }
}
