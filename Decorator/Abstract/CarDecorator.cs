using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Abstract
{
   public abstract class CarDecorator : ICar
    {
        private ICar _car;

        public CarDecorator(ICar car)
        {
            _car = car;
        }

        public string Brand => _car.Brand;

        public string Model => _car.Model;

        public double Price => _car.Price;
    }
}
