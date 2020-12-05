using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveApp_SwitchCaseExmaple
{
    class Program
    {
        static void Main(string[] args)
        {
            string NameManeger="";

            Console.WriteLine("Please Enter Name :");
            NameManeger = Console.ReadLine();

            switch (NameManeger)
            {
                case "iman":
                    {

                    Console.WriteLine("Modir barnameh nevisi");
                    break;

                    }

                case "mohamamd reza":
                    {

                        Console.WriteLine("Student");
                        break;

                    }

                case "hamid":
                    {

                        Console.WriteLine("ostad");
                        break;

                    }

                case "javid":
                    {

                        Console.WriteLine("Moalem riazi");
                        break;

                    }
                    
            }

            Console.ReadKey();
        }
    }
}
