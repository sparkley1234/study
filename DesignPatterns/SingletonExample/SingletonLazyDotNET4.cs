using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public class SingletonLazyDotNET4
    {
        private static readonly Lazy<SingletonLazyDotNET4> instance = new Lazy<SingletonLazyDotNET4>(()=> new SingletonLazyDotNET4(), true);
        private SingletonLazyDotNET4()
        {

        }
        public static SingletonLazyDotNET4 Instance { get { return instance.Value; } }

        public static void SayHi()
        {
            Console.WriteLine("Hi There!");
        }
    }
}
