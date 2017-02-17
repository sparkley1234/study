using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Error Compile time error: A namespace declaration cannot have modifiers or attributes
//public namespace AccessModifiersLibrary
namespace AccessModifiersLibrary
{
    internal class ClassA
    {
    }
    class ClassB
    {
        private class PrivateClassA
        {

        }

    }


    

}
    //can not explicitly defined as private
    //Compile time error: Elements defined in a namespace cannot be explicitly declared as private, protected, or protected internal
    //private class ClassC
    //{
    //}
//The default access for everything in C# is "the most restricted access you could declare for that member".So for example:

//namespace MyCompany
//    {
//        class Outer
//        {
//            void Foo() { }
//            class Inner { }
//        }
//    }
////is equivalent to

//namespace MyCompany
//    {
//        internal class Outer
//        {
//            private void Foo() { }
//            private class Inner { }
//        }
//    }
//}
