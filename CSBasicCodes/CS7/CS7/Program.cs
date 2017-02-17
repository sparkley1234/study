using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
delegate void process_delegate(int num1, int num2);
namespace CS7
{
    /// <summary>
    /// Definition : Anonymous methods provide a technique to pass a code block as a delegate parameter. 
    /// Anonymous methods are basically methods without a name, having method body.
    /// Benefits:
    //To reduce code the amount of code
    //To reduce complexity of code.
    //To increase readability of code. 
    //Anonymous method can use any local variable declared outside of method.
    //Rules : 
    //Cannot have jump statement that targets outside the anonymous method.
    //Jump statement from outside of anonymous method cannot target inside anonymous method. 
    //Anonymous method cannot use Ref and Out parameter from outside of anonymous method.
    /// </summary>
    /// <param name="args"></param>
    class delegate_program
    {
        static int num = 0;
        public static void AddNum(int p, int q)
        {
            num = p + q;
            Console.WriteLine("AddNum value: {0}", num);
        }

        public static void MultNum(int p, int q)
        {
            num = p * q;
            Console.WriteLine("MultNum value: {0}", num);
        }

        static void Main(string[] args)
        {
            //create delegate instances using anonymous method
            process_delegate pd = delegate (int x, int y)
            {
                Console.WriteLine("Anonymous Method: {0}-{1}", x, y);
            };

            //calling the delegate using the anonymous method
            pd(20, 10);

            //instantiating the delegate using the named methods
            pd = new process_delegate(AddNum);

            //calling the delegate using the named methods
            pd(10, 30);

            //instantiating the delegate using another named methods
            pd = new process_delegate(MultNum);

            //calling the delegate using the named methods
            pd(5, 10);
            Console.Read();
        }
    }
}
