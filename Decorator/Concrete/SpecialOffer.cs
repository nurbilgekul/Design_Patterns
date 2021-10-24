using Decorator.Abstract;
using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Concrete
{
    class SpecialOffer:CarDecorator
    {
        public SpecialOffer(ICar car) : base(car) { }

        public int DiscountPercentage { get; set; }
        public string Offer { get; set; }

        public double newPrice
        {
            get
            {
                double price = base.Price;
                int percentage = 100 - DiscountPercentage;
                return Math.Round((price * percentage) / 100, 2);
            }
        }

    }
}
