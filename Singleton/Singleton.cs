using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private Singleton() { }

        private static Singleton _instance;


        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
        //cannot use by "new"  operator because of 'private' singleton
        //use it with:
        Singleton singleton = Singleton.GetInstance();
    }
        
}
