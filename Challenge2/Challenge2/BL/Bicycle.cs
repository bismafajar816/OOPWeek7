using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2.BL
{
    class Bicycle
    {
        private int cadence;
        private int gear;
        private int speed;
        public Bicycle(int cadence, int gear, int speed)
        {
            this.cadence = cadence;
            this.gear = gear;
            this.speed = speed;
        }
        public void SetCadence(int cadence)
        {
            this.cadence = cadence;
        }
        public void SetGear(int gear)
        {
            this.gear = gear;
        }
        public void  ApplyBrake(int decrement)
        {
            speed = speed - decrement;
        }
        public void SpeedUp(int increment)
        {
            speed = speed + increment;
        }
    }

}
