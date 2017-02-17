using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    public class Program
    {
        static void Main(string[] args)
        {
            A obj1 = new A();
            //Console.WriteLine("Interface Method Implemented, but whose? donno:\\)");
            obj1.doSomething();
            IC obj2 = new B();
            obj2.doSomething();
            ID obj3 = new B();
            obj3.doSomething();

        }
    }
    public interface IA
    {
        void doSomething();
    }
    public interface IB
    {
        void doSomething();
    }

    public class A : IA, IB
    {
        public void doSomething()
        {
            Console.WriteLine("Interface Method Implemented, but whose? donno:\\)");
        }

    }

    public interface IC
    {
        void doSomething();
    }
    public interface ID
    {
        void doSomething();
    }
    public class B : IC, ID
    {
        void IC.doSomething()
        {
            Console.WriteLine("doSomething from IC");
        }
        void ID.doSomething()
        {
            Console.WriteLine("doSomething from ID");
        }

    }
}
