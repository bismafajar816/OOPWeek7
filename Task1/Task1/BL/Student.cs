using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    class Student
    {
        private string name;
        protected string session;
        protected bool isDayscholar;
        protected float EcatMarks;
        protected int FscMarks;
       
        protected Student(string name, string session, bool isDayscholar, float EcatMarks, int FscMarks)
        {
            this.name = name;
            this.session = session;
            this.isDayscholar = isDayscholar;
            this.EcatMarks = EcatMarks;
            this.FscMarks = FscMarks;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public double CalculateMerit()
        {
            double merit = 0.0;
            merit = (((60.0/400) * EcatMarks) + ((40.0/1100) * FscMarks));
            return merit;
        }
    }
}
