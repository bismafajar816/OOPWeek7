using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            DayScholar scholar = new DayScholar("swl", 10,"ali","2022",true,44.5f,1099);
            double merit = scholar.CalculateMerit();
            Console.WriteLine(merit);
            Console.WriteLine(scholar.GetName());
           
            scholar.SetDistance(30);
            double charges =  scholar.GetBusFees();
            Console.WriteLine(charges);
            Console.ReadKey();
            
        }
    }
}
