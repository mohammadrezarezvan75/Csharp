using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Number 1 :");
            string Num1=Console.ReadLine();
            Console.WriteLine("Please Enter Number 2 :");
            string Num2=Console.ReadLine();

            int FirstNumber = Convert.ToInt32(Num1);
            int SecoundNumber = Convert.ToInt32(Num2);
            int Sum = FirstNumber + SecoundNumber;
            Console.WriteLine("Sum :"+Sum);
            Console.ReadKey();

        }
    }
}
