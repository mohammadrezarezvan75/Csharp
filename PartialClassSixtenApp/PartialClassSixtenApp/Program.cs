using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassSixtenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass c1=new MyClass();
            Console.WriteLine(c1.Sum(3, 2));
            Console.ReadKey();
        }

        
    }
}
