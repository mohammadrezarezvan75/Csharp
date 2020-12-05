using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenApp
{
    class Car
    {
        private int _speed;
        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                if (value > 120)
                {
                    Console.WriteLine("bichareh mimiria ....");
                }
                else
                {
                    _speed = value;
                }

                
            }


        }

        private string  _carname="Pride";

        public string Carname 
        {
            get
            {
                return _carname;
            }
        }

    }
}
