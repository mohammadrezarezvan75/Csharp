using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericlist
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[3];
            string[] Names = { "mohammad", "ahmmadreza", "hasan" };

            List<int> nam = new List<int>();
            nam.Add(1);
            nam.Add(2);
            nam.Add(3);
            nam.Add(4);
            nam.Remove(2);
            nam.RemoveAt(0);

            List<string> namePersons = new List<string>();
            namePersons.Add("mohammad");
            namePersons.Add("iman");
            namePersons.Add("alireza");
            namePersons.Add("ahmmadreza");

            foreach(string persens in namePersons)
            {
                Console.WriteLine("name ha :" + persens);
            }
            Console.ReadKey();


        }
    }
}
