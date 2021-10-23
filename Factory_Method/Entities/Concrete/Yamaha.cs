using Factory_Method.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Factory_Method.Entities.Concrete
{
    public class Yamaha : MotorcycleFactory
    {
        public override void createMotorcycle()
        {
            MessageBox.Show("XV950R üretildi.");
        }
    }
}
