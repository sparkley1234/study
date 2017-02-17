using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS8
{
delegate void Procedure();
delegate void Procedure1();
    delegate void Procedure2(string text);



    class DelegateDemo
    {
        public static void Method1()
        {
            Console.WriteLine("Method 1");
        }

        public static void Method2()
        {
            Console.WriteLine("Method 2");
        }

        public void Method3()
        {
            Console.WriteLine("Method 3");
        }

        // Anonymous delegates
        

        static Procedure1 someProcs1 = null;
        private static void AddProc1()
        {
            int variable = 100;

            someProcs1 += new Procedure1(delegate
            {
                Console.WriteLine(variable);
            });
        }

        static Procedure2 someProcs2 = null;
        private static void AddProc2()
        {
            int variable = 100;

            someProcs2 += new Procedure2(delegate (string text)
            {
                Console.WriteLine(text + ", " + variable.ToString());
            });
        }

        static void Main()
        {
            Procedure someProcs = null;

            someProcs += new Procedure(DelegateDemo.Method1);
            someProcs += new Procedure(Method2);  // Example with omitted class name

            DelegateDemo demo = new DelegateDemo();

            someProcs += new Procedure(demo.Method3);
            someProcs();
            someProcs -= new Procedure(demo.Method3);
            someProcs();

            
            someProcs1 += new Procedure1(delegate { Console.WriteLine("test"); });
            someProcs2 += new Procedure2(delegate (string text) { Console.WriteLine(text); });

            Console.ReadLine();
        }
    }
}
