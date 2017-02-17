using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class SingletonClient
    {
        public void UseSingleton()
        {
            //http://csharpindepth.com/Articles/General/Singleton.aspx
            //Essentially, a singleton is a class 
            //which only allows a single instance of itself to be created, and usually gives simple access to that instance.
            //Most commonly, singletons don't allow any parameters to be specified when creating the instance
            //Old one without propertyt : 
            //Singleton s1 = Singleton.Instance();
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;
            SingletonLazy.SayHi();
            // if you dont need to be a lazy then simply go with SingletonLazy.
            SingletonLazyElegant.SayHi();// there is no class initialization anymore, as in SingletonLazy class
            SingletonLazyElegant SLE1 = SingletonLazyElegant.Instance;
            
            if(s1.GetHashCode() == s2.GetHashCode())
            {
                Console.WriteLine("They are same. Haha!");
                Console.ReadLine();
                
                
            }

        }
    }
}
