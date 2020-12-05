using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 10;
            int b, c;
            b = 20;
            c = a + b;

            //------------------------------------------

            string Name = "mohammad";
            string LastName = "Rezvan";
            string FullName = Name + LastName;

            //------------------------------------------

            double Price = 2.500;
            bool Active = true;

            //------------------------------------------

            int d = 20;
            string Test =Convert.ToString(d);

            //------------------------------------------

            string Num = "50";
            int Number =Convert.ToInt32(Num);
            Number += 3;
            //-----------------------------------------

            bool isActive = Convert.ToBoolean("true");

            //------------------------------------------

            Console.WriteLine(c);
            Console.WriteLine(FullName);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(Test);
            Console.WriteLine(Number);
            Console.WriteLine(isActive);
            Console.ReadKey();

        }
    }
}
