using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            checkBox1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void Exit()
        {
            Application.Exit();
        }
        private void CloseForm()
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label3.Visible = true;
                label5.Visible = true;
                maskedTextBox1.Visible = true;
                textBox2.Visible = true;
            }
            else
            {
                label3.Visible = false;
                label5.Visible = false;
                maskedTextBox1.Visible = false;
                textBox2.Visible = false;
            }
        }
    }
}
