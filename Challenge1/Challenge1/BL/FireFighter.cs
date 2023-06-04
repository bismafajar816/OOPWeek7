using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
   public class FireFighter:Employee
    {
       public bool DriveTruck()
        {
            FireFighter f = new FireFighter();
           if(f.GetName() != "")
            {
                return true;
            }
           else
            {
                return false;
            }
            
        }
        public bool fireExtinghuish()
        {
            if(DriveTruck())
            {
                return true;
            }
            return false;
        }
    }
}
