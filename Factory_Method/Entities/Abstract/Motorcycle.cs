using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Entities.Abstract
{
    public abstract class Motorcycle
    {
        private string marka = null;
        private string model = null;
        private int beygirGucu = 0;

        public Motorcycle(string marka,  string model,  int beygirGucu)
        {
            setMarka(marka);
            setModel(model);
            setBeygirGucu(beygirGucu);
        }
        public String getMarka()
        {
            return marka;
        }
        public void setMarka(string marka)
        {
            this.marka = marka;
        }
        public String getModel()
        {
            return model;
        }
        public void setModel(string model)
        {
            this.model = model;
        }
        public int getBeygirGucu()
        {
            return beygirGucu;
        }
        public void setBeygirGucu( int beygirGucu)
        {
            this.beygirGucu = beygirGucu;
        }

    }
}
