using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public class SingletonLazyElegant
    {
        private static class SingletonHolder
        {
            internal static readonly SingletonLazyElegant instance = new SingletonLazyElegant();
            //Empty static constructor, force laziness
            static SingletonHolder()
            {

            }
        }
        
        private SingletonLazyElegant()
        {
            Console.WriteLine("SingletonLazyElegant Constructor");

        }
        public static SingletonLazyElegant Instance
        {
            get
            {
                return SingletonHolder.instance;
            }
        }

        public static void SayHi()
        {
            Console.WriteLine("Say Hi!");
        }
    }
}
