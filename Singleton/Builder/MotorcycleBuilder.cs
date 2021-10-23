using Singleton.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Builder
{
   abstract class MotorcycleBuilder
   {
        protected Motorcycle motorcycle;
        //we mark the motorcycle reference as protected in our Builder class. This is because this field can be accessed from Derived Classes to which this Builder Class will be applied.
        public Motorcycle Motorcycle
        {
            get { return motorcycle; }
        }

        public abstract void SetMarka();
        public abstract void SetModel();
        public abstract void SetKM();
        public abstract void SetGasoline();
    }
}
