using System;
using System.Windows.Forms;

namespace CSharpOop.TemperatureConverterTask
{
    public partial class TemperatureConverterView : Form, IView
    {
        private readonly IController controller;

        public TemperatureConverterView(IController controller, IBasicScale[] scales)
        {
            this.controller = controller;

            InitializeComponent();

            foreach (var e in scales)
            {
                comboBox1.Items.Add(e);
                comboBox2.Items.Add(e);
            }

            comboBox1.DisplayMember = "Name";
            comboBox2.DisplayMember = "Name";
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

        private void TemperatureConverterView_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        public IBasicScale GetFromScale()
        {
            return (IBasicScale)comboBox1.SelectedItem;
        }

        public IBasicScale GetToScale()
        {
            return (IBasicScale)comboBox2.SelectedItem;
        }

        public double GetValueForConvert()
        {
            return double.Parse(maskedTextBox1.Text);
        }
    }
}
