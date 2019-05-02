using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        SeparateDataStorage separateDataStorage;
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(SeparateDataStorage separateDataStorage)
        {
            InitializeComponent();
            this.separateDataStorage = separateDataStorage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeparateClass separateClass = new SeparateClass();
            separateClass.displayName(separateDataStorage);
            displayBDay();
        }
        public void displayBDay()
        {
            try
            {
                DateTime date = Convert.ToDateTime(maskedTextBox1.Text);
                MessageBox.Show("Your birthday is " + date.Month + "/" + date.Day + "/" + date.Year, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message + "\n\n" + " Please enter a valid date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
