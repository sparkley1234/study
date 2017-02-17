using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public class SingletonLazy
    {
        private static readonly SingletonLazy instance = new SingletonLazy();
        private SingletonLazy()
        {
            Console.WriteLine("SingletonLazy Constructor");

        }
        static SingletonLazy() // lazy version
        {

        }

        public static SingletonLazy Instance
        {
            get
            {
                return instance;
            }
        }

        public static void SayHi()
        {
            Console.WriteLine("Say Hi!");
        }
    }
}
