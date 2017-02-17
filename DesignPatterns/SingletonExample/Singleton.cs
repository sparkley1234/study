using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public class Singleton
    {
        private static readonly object mutex = new object();
        private static Singleton instance = null;
        private Singleton()
        {

        }
        //public static Singleton Instance()
        //{
        //    if(instance == null)
        //    {
        //        instance = new Singleton();
        //    }
        //    return instance;

        //}
        public static Singleton Instance
        {
            get {
                if(instance == null) { // null checking before lock double checking , 
                    //suppose two thread are entering one will enter and pass the lock and another will wait
                    lock (mutex) // thread safe
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                        
                    }
                    
                }
                return instance;

            }

        }
    }
}
