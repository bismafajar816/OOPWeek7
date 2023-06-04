using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    class FireChief:Employee
    {
        public bool DriveTruck()
        {
            FireFighter f = new FireFighter();
            if (f.GetName() != "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Delegate()
        {
            return true;
        }
    }
}
