using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "mohammad reza";
            Console.WriteLine(Name.ToLower());
            SayHello();

            //int Addition = Sum(2, 4);//حالت اول
            Console.WriteLine(Sum(2, 4)); //حالت دوم
            int Add = sum2();//پیش فرض 



            Console.WriteLine(FullName("Mohammad", "Rezvan"));
            SayHello("mohammad");
            Console.ReadKey();
        }

        static void SayHello()
        {
            Console.WriteLine("salam");
        }

        static void SayHello(string name)
        {
            Console.WriteLine(name + "hello user");
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int sum2(int a = 5, int b = 5)
        {
            return a + b;
        }


        static string FullName(string Name, string Family)
        {

            return Name + "" + Family;
        }

        static bool SendEmail(string to, string subject, string body)
        {
            //Send Email
            return true;
        }

    }
}
