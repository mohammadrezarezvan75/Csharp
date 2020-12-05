using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveApp_if
{
    class Program
    {
        static void Main(string[] args)
        {
            //== مساوی
            //!= مخالف
            //< کوچک تر
            //> بزرگ تر
            //<= کوچک تر مساوی
            //>= بزرگ تر مساوی

            string Name = "";
            string Family = "";

            Console.WriteLine("Please Enter Name :");
            Name = Console.ReadLine();
            Name = Name.ToLower();

            Console.WriteLine("Please Enter Family :");
            Family = Console.ReadLine();
            Family = Family.ToLower();

            //if (Name == "mohammad" || Family == "rezvan")

            if (Name == "mohammad" && Family=="rezvan")
                
            {
                Console.WriteLine("hello Manager !");

            }
            else
            {
                Console.WriteLine("Hello User");
                
            }
            Console.ReadKey();
        }
    }
}
