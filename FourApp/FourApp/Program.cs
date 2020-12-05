using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber = 0;
            int SecoundNumber = 0;
            int sum;

            try
            {
                Console.WriteLine("Please Enter Number1 :");
                FirstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter Number2 :");
                SecoundNumber = Convert.ToInt32(Console.ReadLine());
            }

            catch(FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please Enter Number....!");
                Console.ResetColor();
            }

            catch(SqlExeption){
                Console.WriteLine("sql");
            }

            catch
            {
                Console.WriteLine("salam");
            }

            finally
            {
                Console.WriteLine("Finally");
            }
            sum = FirstNumber + SecoundNumber;
            Console.WriteLine("sum is " + sum);
            Console.ReadKey();



        }
    }
}
