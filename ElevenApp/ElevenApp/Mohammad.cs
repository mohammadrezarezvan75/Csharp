using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenApp
{
    class Mohammad : IMyInterface
    {

        public string HelloUser(string name)
        {
            return "hello    !" + name;
        }



        public void ControlSpeed(int Speed)
        {
            Console.WriteLine("Control Speed !");
        }
    }
}
