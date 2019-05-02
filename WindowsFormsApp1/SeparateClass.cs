using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public  class SeparateClass
    {
        public void displayName(string name)
        {
             MessageBox.Show("Hello " + name);
        }
        public void displayName(SeparateDataStorage separateDataStorage)
        {
             MessageBox.Show("Hello " + separateDataStorage.nameForm1);
        }
    }
}
