using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenApp
{
    class HiUser : IMyInterface
    {

        public string HelloUser(string name)
        {
            return "salam baradar  !" + name;
        }


        public void ControlSpeed(int Speed)
        {
            Console.WriteLine("Control Speed !");
        }
    }
}
