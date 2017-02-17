using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public class SingletonSimple
    {

        private static readonly SingletonSimple instance = new SingletonSimple();
        private SingletonSimple()
        {

        }        
        public static SingletonSimple Instance {
            get {
                return instance;
            }
        }
        
    }
}
