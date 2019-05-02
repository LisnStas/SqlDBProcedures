using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SeparateClass separateClass = new SeparateClass();
        SeparateDataStorage separateDataStorage = new SeparateDataStorage();

        private void button1_Click(object sender, EventArgs e)
        {
            separateDataStorage.nameForm1 = textBox1.Text;
            separateClass.displayName(textBox1.Text);
        }
        
        public void exitApp()
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            exitApp();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            separateDataStorage.nameForm1 = textBox1.Text;
            Form2 form2 = new Form2(separateDataStorage);
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            separateDataStorage.nameForm1 = textBox1.Text;
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            separateDataStorage.nameForm1 = textBox1.Text;
            Form6 form6 = new Form6(separateDataStorage);
            form6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            separateDataStorage.nameForm1 = textBox1.Text;
            Form3 form3 = new Form3();
            form3.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            separateDataStorage.nameForm1 = textBox1.Text;
            Form4 form4 = new Form4(separateDataStorage);
            form4.Show();
        }
    }
}
