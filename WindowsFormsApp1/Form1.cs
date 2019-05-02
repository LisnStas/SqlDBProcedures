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

        public void exitApp()
        {
            Application.Exit();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            exitApp();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            separateDataStorage.nameForm1 = textBox1Main.Text;
            separateClass.displayName(textBox1Main.Text);
        }

        private void project2_Click(object sender, EventArgs e)
        {
            separateDataStorage.nameForm1 = textBox1Main.Text;
            Form2 form2 = new Form2(separateDataStorage);
            form2.Show();
        }

        private void project3_Click(object sender, EventArgs e)
        {
            separateDataStorage.nameForm1 = textBox1Main.Text;
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void project4_Click(object sender, EventArgs e)
        {
            separateDataStorage.nameForm1 = textBox1Main.Text;
            Form6 form6 = new Form6(separateDataStorage);
            form6.Show();
        }

        private void project5_Click(object sender, EventArgs e)
        {
            separateDataStorage.nameForm1 = textBox1Main.Text;
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void project6_Click(object sender, EventArgs e)
        {
            separateDataStorage.nameForm1 = textBox1Main.Text;
            Form4 form4 = new Form4(separateDataStorage);
            form4.Show();
        }

        private void project7_Click(object sender, EventArgs e)
        {

        }

        private void project8_Click(object sender, EventArgs e)
        {

        }

        private void project9Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"I’ve added the Northwind database and persisted changes");
        }

        private void project10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"I’ve added the Northwind database and persisted changes");
        }

        private void project11_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"I’ve added the professions and states tables to the Northwind database.");
        }

        private void Project12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"I’ve created  assigned stored procedures in the Northwind database.");
        }

        private void Project13_Click(object sender, EventArgs e)
        {
            Form7 openForm7 = new Form7();
            openForm7.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"I’ve created  assigned stored procedures in the Northwind database.");
        }
    }
}
