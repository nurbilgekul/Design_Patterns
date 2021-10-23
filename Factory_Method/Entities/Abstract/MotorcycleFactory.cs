using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Entities.Abstract
{
    public abstract class MotorcycleFactory
    {

        private List<Motorcycle> motorListesi = new List<Motorcycle>();
  
        public MotorcycleFactory()
        {
            createMotorcycle();

        }
 
        public abstract void createMotorcycle();
        public List<Motorcycle> getMotorListesi()
        {
            return motorListesi;
        }
        public void setMotorListesi(List<Motorcycle> motorListesi)
        {
            this.motorListesi = motorListesi;
        }
    }
}
