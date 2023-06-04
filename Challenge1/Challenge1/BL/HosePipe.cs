using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    class HosePipe
    {
        private string material;
        private string shape;
        private int diameter;
        private int waterFlow;
        public bool SetMaterial(string material)
        {
            if(material == "soft plastic" || material == "synthetic rubber")
            {
                this.material = material;
                return true;
            }
            else
            {
                return false;
            }

        }
        public string GetMaterial()
        {
            return material;
        }
        public bool SetShape(string shape)
        {
            if(shape == "circular" || shape == "cylindrical")
            {
                this.shape = shape;
                return true;
            }
            return false;
        }
        public string GetShape()
        {
            return shape;
        }
        public void SetDiameter(int diameter)
        {
            this.diameter = diameter;
        }
        public int GetDiameter()
        {
            return diameter;
        }
        public void SetWaterFlow(int waterFlow)
        {
            this.waterFlow = waterFlow;
        }
        public int GetWaterFlow()
        {
            return waterFlow;
        }


    }
}
