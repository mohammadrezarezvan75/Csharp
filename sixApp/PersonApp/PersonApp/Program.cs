using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number person :");
            int Number = Convert.ToInt32(Console.ReadLine());

            string[] Names = new string[Number];

            for (int i = 0; i < Number; i++)
            {
                Console.WriteLine("Please Enter Name" + (i + 1));
                Names[i] = Console.ReadLine();
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***************************");
            Console.ResetColor();

            foreach (string name in Names)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
