using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    class Hostelite : Student
    {
        private int RoomNo;
        public bool IsFridgeAvail;
        public bool isInternetAvail;
        public Hostelite(bool IsFridgeAvail, bool isInternetAvail) :base("Bisma", "2022", true, 330.7F, 1050)
        {
            this.isInternetAvail = isInternetAvail;
            this.IsFridgeAvail = IsFridgeAvail;
        }
        public void SetRoomNo(int RoomNo)
        {
            this.RoomNo = RoomNo;
        }
        public int GetRoomNo()
        {
            return RoomNo;
        }
        public double GetHostelFee()
        {
            if(isInternetAvail && IsFridgeAvail)
            {
                return 12000.0;
            }
            else
            {
                return 10000.0;
            }
        }
    }
}
