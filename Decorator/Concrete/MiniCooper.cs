using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Concrete
{
    public class MiniCooper : ICar
    {
        public string Brand => "Mini Cooper";

        public string Model => "Country Man";

        public double Price => 660000;
    }
}
