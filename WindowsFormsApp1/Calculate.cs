using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   public class Calculate
    {
        public void Calc(DateTime dateBirthDay, SeparateDataStorage separateDataStorage, string name)
        {
            //Get data
            separateDataStorage.birthday = dateBirthDay;
            DateTime dateNow = DateTime.Now;

            //Get year
            int year = dateNow.Year - dateBirthDay.Year;

            if (dateNow.Month < dateBirthDay.Month || (dateNow.Month == dateBirthDay.Month && dateNow.Day < dateBirthDay.Day))
            {
                year--;
            }

            year = 70 - year;

            //Add current data
            DateTime resultDate = DateTime.Now;
            resultDate = resultDate.AddDays(dateBirthDay.Day);
            resultDate = resultDate.AddMonths(dateBirthDay.Month);
            resultDate = resultDate.AddYears(year);

            MessageBox.Show(string.Format("Hello {0} you will retire on {1}/{2}/{3}", name, resultDate.Month, resultDate.Day, resultDate.Year), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
