using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNine
{
    class MyClass
    {
        public string Name;
        public static string Family;

        public static int sum(int a, int b)
        {
            return a + b;
        }

        public MyClass()
        {
            Console.WriteLine("Public Canstractor ....");
        }

        static MyClass()
        {
            Console.WriteLine("Static Canstractor ....");
        }
    }


}
