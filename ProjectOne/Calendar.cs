using System;
using System.Windows.Forms;
namespace ProjectOne
{
    public class Calendar
    {
        public static void Main()
        {
            DateTime now = GetCurrentDate();
            MessageBox.Show($"Today date is {now}");
        }
        static DateTime GetCurrentDate() => DateTime.Now.Date;
    }
}

    
