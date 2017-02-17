using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonClient SC = new SingletonClient();
            SC.UseSingleton();

        }
    }
}
