using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenApp
{
     class Program
    {
        static void Main(string[] args)
        {
            Car pride = new Car();
            pride.Speed = 80;
            //pride.Carname = "98";

            Console.WriteLine("Pride :" + pride.Speed);
            Console.ReadKey();
        }
    }
}
