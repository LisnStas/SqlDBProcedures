using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SeparateDataStorage separateDataStorage;

        public Form2(SeparateDataStorage separateDataStorage)
        {
            InitializeComponent();
            this.separateDataStorage = separateDataStorage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate calculate = new Calculate();
            calculate.Calc(dateTimePicker1.Value, separateDataStorage, textBox1.Text);

            separateDataStorage.nameForm2 = textBox1.Text;
        }
        
        private void Exit()
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exit();
        }
        private void CloseForm()
        {
            Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
