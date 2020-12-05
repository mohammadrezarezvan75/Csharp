using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace twoelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            PersianCalendar persion = new PersianCalendar();
            string p = persion.GetYear(DateTime.Now) + "/" + persion.GetMonth(DateTime.Now) + "/" + persion.GetDayOfMonth(DateTime.Now);
            Console.WriteLine(p);

            
            Console.ReadKey();
        }
    }
}
