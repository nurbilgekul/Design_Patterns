using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.ConcreteBuilder
{
    class HarleyDavidsonConcreteBuilder : Builder.MotorcycleBuilder
    {

        public HarleyDavidsonConcreteBuilder()
        {
            motorcycle = new Product.Motorcycle();
        }
        public override void SetKM() => motorcycle.KM = 100;
        public override void SetMarka() => motorcycle.Marka = "Harley Davidson";
        public override void SetModel() => motorcycle.Model = "Iron 883";
        public override void SetGasoline() => motorcycle.Gasoline = true;
        
    }
}
