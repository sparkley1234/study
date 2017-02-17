using System;
using AccessModifiersLibrary;

namespace CS4
{
    class Modifiers
    {
        static void AAA()
        {
            Console.WriteLine("Modifiers AAA");
        }

        public static void BBB()
        {
            Console.WriteLine("Modifiers BBB");
            AAA();
        }
    }
    class ModifiersBase
    {
        static void AAA()
        {
            Console.WriteLine("ModifiersBase AAA");
        }
        public static void BBB()
        {
            Console.WriteLine("ModifiersBase BBB");
        }
        protected static void CCC()
        {
            Console.WriteLine("ModifiersBase CCC");
        }
    }

    class ModifiersDerived : ModifiersBase
    {
        public static void XXX()
        {

            //Error > AAA();
            //Error Inaccessible to its protection levels 
            BBB();
            CCC();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Modifiers.BBB();
            //Error > Modifiers.AAA();
            //Error Inaccessible to its protection levels 
            ModifiersDerived.XXX();
            //Compile time error: Error ClassA is Inaccessible to its protection levels
            //Error > ClassA clsA;
            //Compile time error: Error ClassB is Inaccessible to its protection levels
            //Error > ClassB
            Console.ReadKey();

        }
    }
}