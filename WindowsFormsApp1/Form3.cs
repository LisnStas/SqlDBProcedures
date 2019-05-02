using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            checkBox1.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            Close();
        }
        private void Exit()
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Student student = new Student();
                string [] name = textBox1.Text.Split(' ');
                student.FirstName = name[0];

                if (name.Length > 1)
                {
                    student.LastName = name[1];
                }
                else
                {
                    student.LastName = "";
                }

                student.Birthday = dateTimePicker1.Value;
                student.School = textBox2.Text;
                student.ExpGradDate = dateTimePicker2.Value;
                addToXml(student);
            }
            else
            {
                NotStudent notStudent = new NotStudent();
                string [] name = textBox1.Text.Split(' ');
                notStudent.FirstName = name[0];

                if (name.Length > 1)
                {
                    notStudent.LastName = name[1];
                }
                else
                {
                    notStudent.LastName = "";
                }

                notStudent.Birthday = dateTimePicker1.Value;
                addToXml(notStudent);
                MessageBox.Show("Document saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void addToXml(Student student)
        {
            XDocument xdoc = new XDocument();
            // create first elem
            XElement person = new XElement("person");
            // create attribute
            XAttribute birthday = new XAttribute("birthday", student.Birthday.Month + "/" + student.Birthday.Day + "/" + student.Birthday.Year);
            XAttribute Sstudent = new XAttribute("Student", "Yes");
            XAttribute School = new XAttribute("School", student.School);
            XAttribute Grad = new XAttribute("Grad", student.ExpGradDate.Month + "/" + student.ExpGradDate.Day + "/" + student.ExpGradDate.Year);

            XElement name = new XElement("name");
            XElement firstName = new XElement("first-name", student.FirstName);
            XElement lastName = new XElement("last-name", student.LastName);

            //add attribute andelems in first elem
            name.Add(firstName); 
            name.Add(lastName);
            person.Add(birthday);
            person.Add(Sstudent);
            person.Add(School);
            person.Add(Grad);
            person.Add(name);
            
            //create root elem
            XElement people = new XElement("people");
            //add in root elem
            people.Add(person);
            //add root elem in doc
            xdoc.Add(people);
            //save doc
            xdoc.Save("..\\..\\Resources\\people.xml");
        }
        public void addToXml(Person pperson)
        {
            XDocument xdoc = new XDocument();
            // create first elem
            XElement person = new XElement("person");
            // create attribute
            XAttribute birthday = new XAttribute("birthday", pperson.Birthday.Month + "/" + pperson.Birthday.Day + "/" + pperson.Birthday.Year);
            XAttribute Sstudent = new XAttribute("Student", "No");

            XElement name = new XElement("name");
            XElement firstName = new XElement("first-name", pperson.FirstName);
            XElement lastName = new XElement("last-name", pperson.LastName);

            //add attribute andelems in first elem
            name.Add(firstName);
            name.Add(lastName);
            person.Add(birthday);
            person.Add(Sstudent);
            person.Add(name);

            //create root elem
            XElement people = new XElement("people");
            //add in root elem
            people.Add(person);
            //add root elem in doc
            xdoc.Add(people);
            //save doc
            xdoc.Save("..\\..\\Resources\\people.xml");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.Visible = true;
                dateTimePicker2.Visible = true;
                label5.Visible = true;
                label3.Visible = true;
            }
            else
            {
                textBox2.Visible = false;
                dateTimePicker2.Visible = false;
                label5.Visible = false;
                label3.Visible = false;
            }
        }
    }
}
