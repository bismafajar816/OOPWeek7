using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
   
    class DayScholar : Student
    {
        public string PickUpPoint;
        public int BusNo;
        private float Distance;
        public DayScholar(string PickUpPoint, int BusNo,string name, string session, bool isDayscholar, float EcatMarks, int FscMarks) : base(name,session,isDayscholar,EcatMarks,FscMarks)
        {
            this.BusNo = BusNo;
            this.PickUpPoint = PickUpPoint;
           
        }
        public void SetDistance(float Distance)
        {
            this.Distance = Distance;
        }
        public float GetDistance()
        {
            return Distance;
        }
        public double GetBusFees()
        {            
            double fees = 0.0;
            fees = Distance * 30.0*30; 
            return fees;
        }

    }
}
