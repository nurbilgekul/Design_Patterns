using Builder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Director
{
    class CreateMotorcycle
    {
        public void Create(MotorcycleBuilder motorcycle)
        {
            motorcycle.SetKM();
            motorcycle.SetMarka();
            motorcycle.SetModel();
            motorcycle.SetGasoline();
        }
    }
}
