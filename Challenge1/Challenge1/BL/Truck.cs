using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    class Truck
    {
       public HosePipe pipe ;
        public Ladder ladder;
        public Employee emp;
        public Truck()
        {
            ladder = new Ladder();
            emp = new Employee();
        }
        public void SetHosepipe(HosePipe pipe)
        {
            this.pipe = pipe;
        }

    }
}
