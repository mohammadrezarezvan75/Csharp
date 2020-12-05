using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int ADD = MyCalss.sum(3, 5);
            Console.WriteLine(ADD);
            Console.WriteLine(MyCalss.FullName("mohammad", "rezvan"));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("***********************************************************");
            Console.ResetColor();

            Car car1 = new Car();
            car1.CarName = "Benz";
            car1.CarSpeed = 200;
            car1.CarModel = "220ig";

            Car car2 = new Car();
            car2.CarName = "BMW";
            car2.CarSpeed = 220;
            car2.CarModel = "4ig";

            Console.WriteLine(car1.CarName + " " + car1.CarModel + " " + car1.CarSpeed);
            Console.WriteLine(car2.CarName + " " + car2.CarModel + " " + car2.CarSpeed);

            Person mohammad = new Person("mohamamd", "rezvan", "Toplearn");
            Console.WriteLine("name :" + " " + mohammad.name + " " + mohammad.Family + " " + mohammad.Website);

            Console.WriteLine("***********************************************************");
            Console.WriteLine("Please Enter Person Name :");
            int Number = Convert.ToInt32(Console.ReadLine());
            Person[] pepole = new Person[Number];

            for (int i = 0; i < Number; i++)
            {
                Console.WriteLine("Please Enter Person Name :" + (i + 1));
                string name = Console.ReadLine();

                Console.WriteLine("Please Enter Person Family :" + (i + 1));
                string Family = Console.ReadLine();

                Console.WriteLine("Please Enter Person Website :" + (i + 1));
                string Website = Console.ReadLine();

                Person p1 = new Person(name, Family, Website);
                pepole[i] = p1;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Person p in pepole)
            {
                Console.WriteLine("name :" + " " + p.name + " " + p.Family + " " + p.Website);
            }
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
