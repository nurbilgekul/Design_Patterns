using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Director
{
    class CreateMotorcycle
    {
        public void Create(Builder.MotorcycleBuilder motorcycle)
        {
            motorcycle.SetKM();
            motorcycle.SetMarka();
            motorcycle.SetModel();
            motorcycle.SetGasoline();
        }
    }
}
