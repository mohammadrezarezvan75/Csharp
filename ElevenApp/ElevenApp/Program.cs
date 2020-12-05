using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Mohammad mr = new Mohammad();
            Console.WriteLine(mr.HelloUser("mohamamd rezvan"));



            HiUser h = new HiUser();
            Console.WriteLine(h.HelloUser("mohamamd rezvan"));

            IMyInterface mrr = new Mohammad();
            IMyInterface salamhiuser = new HiUser();


            List<Person> People = new List<Person>();
            Person p1 = new Person();
            p1.Name = "mohammad reza";
            p1.Family = "rezvan";
            p1.Age = 24;
            People.Add(p1);

            Person p2 = new Person();
            p2.Name = "poya ";
            p2.Family = "Baoimd";
            p2.Age = 24;
            People.Add(p2);

            foreach (Person p in People)
            {
                Console.WriteLine("*******************************************************");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Name : " + p.Name + " - " + "Family :" + p.Family + " - " + "Age :" + p.Age);
                Console.ResetColor();
            }
            Console.ReadKey();
        }
    }
}
