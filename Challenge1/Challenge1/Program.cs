using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1.BL;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck truck = new Truck();
            truck.ladder = new Ladder();
            truck.ladder.SetColor("Pink ")  ;
            truck.ladder.SetLength(80);
            truck.emp.SetAddress("Swl");
            truck.emp.SetName("Ali");
            truck.emp.SetPhone("03045");
            HosePipe h = new HosePipe();          
            h.SetDiameter(200);
            h.SetWaterFlow(150);
            truck.SetHosepipe(h);
            FireFighter fighter = new FireFighter();
            if(h.SetMaterial("plastic") &&  h.SetShape("circular") && (fighter.DriveTruck()))
            {
                Console.WriteLine("The truck is working. ");
            }
            else 
            {
                Console.WriteLine("The truck is not working. ");
            }
            Console.ReadKey();
        }
    }
}
