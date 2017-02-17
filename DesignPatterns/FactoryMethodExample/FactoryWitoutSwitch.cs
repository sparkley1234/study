using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{

    //http://stackoverflow.com/questions/33878216/factory-pattern-without-a-switch-or-if-then
    //http://tutorials.jenkov.com/dependency-injection/dependency-injection-replacing-factory-patterns.html

    public interface IPosition
        {
            string Title { get; }
        }

        class Manager : IPosition
        {
            public string Title
            {
                get { return "Manager"; }
            }
        }

        class Clerk : IPosition
        {
            public string Title
            {
                get { return "Clerk"; }
            }
        }

        class Programmer : IPosition
        {
            public string Title
            {
                get { return "Programmer"; }
            }
        }

        static class Factory
        {
            public static T Create<T>() where T : IPosition, new()
            {
                return new T();
            }
        }

    class FactoryWitoutSwitch
    {
        static void Main(string[] args)
        {

            IPosition position0 = Factory.Create<Manager>();
            Console.WriteLine("0: " + position0.Title);

            IPosition position1 = Factory.Create<Clerk>();
            Console.WriteLine("1: " + position1.Title);

            IPosition position2 = Factory.Create<Programmer>();
            Console.WriteLine("1: " + position2.Title);

            Console.ReadLine();
        }
    }
}
