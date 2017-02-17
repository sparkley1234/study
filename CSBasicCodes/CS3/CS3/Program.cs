using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3
{
    class MyConstant
    {
        // compile time to MSIL need to compile host assembly as Raj B 
        public const int number = 5;
        //Error number is nor in current context number = 10;
    }
    class MyReadOnly
    {
        public readonly int readOnlyNumber = 10;
    }

    class ReadOnlyEx
    {
        public readonly int number = 10;
        public ReadOnlyEx()
        {
            number = 20;
        }
        public ReadOnlyEx(bool IsDifferentInstance)
        {
            number = 100;
        }
    }

    class MyStaticClass
    {
        public static readonly int x;
        public static int y;

        /// <summary>
        /// A static constructor cannot be called directly.
        ///The user has no control on when the static constructor is executed in the program.
        ///A typical use of static constructors is when the class is using a log file and the constructor is used to write entries to this file.
        /// </summary>
        static MyStaticClass()
        {
            x = 100;
            y = 10;
            Console.WriteLine("Inside static Constructor");
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        public MyStaticClass()
        {
            // Error : will be only assigned in Static constructor x = 100;
            y = 15;
            Console.WriteLine("Inside Constructor");
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyConstant.number);
            MyReadOnly obj = new MyReadOnly();
            Console.WriteLine(obj.readOnlyNumber);

            ReadOnlyEx readOnlyInstance = new ReadOnlyEx();
            Console.WriteLine(readOnlyInstance.number);

            ReadOnlyEx differentInstance = new ReadOnlyEx(true);
            //Error can not assign differentInstance.number = 11
            Console.WriteLine(differentInstance.number);

            // static read only 
            MyStaticClass objSC = new MyStaticClass();
            // Error MyStaticClass.x = 10;
            Console.WriteLine(MyStaticClass.x);
            Console.WriteLine(MyStaticClass.y);

            MyStaticClass objSC2 = new MyStaticClass();
            Console.WriteLine(MyStaticClass.x);
            Console.WriteLine(MyStaticClass.y);

            MyStaticClass.y = 11;
            Console.WriteLine(MyStaticClass.y);

            Console.ReadLine();
        }
    }
}
