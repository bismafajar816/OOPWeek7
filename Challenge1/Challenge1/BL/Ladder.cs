using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    class Ladder
    {
        private int Length;
        private string color;
        public Ladder()
        {

        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public string GetColor()
        {
            return color;
        }
        public void SetLength(int Length)
        {
            this.Length = Length;
        }
        public int GetLength()
        {
            return Length;
        }

    }
}
