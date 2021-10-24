using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Interface
{
    public interface ICar
    {
        string Brand { get; }
        string Model { get; }
        double Price { get; }
    }
}
