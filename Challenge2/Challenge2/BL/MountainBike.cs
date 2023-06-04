using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2.BL
{
    class MountainBike : Bicycle
    {
        private int seatHeight;
        public MountainBike(int seatHeight):base(12,3,50)
        {
            
            this.seatHeight = seatHeight;
        }
        public void SetSeatHeight(int seatHeight)
        {
            this.seatHeight = seatHeight;
        }

    }
}
