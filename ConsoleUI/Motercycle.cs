using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motercycle : Vehicle
    {
        public Motercycle() 
        {
        }

        public bool HasSidecart { get; set; } = false;

        public override void DriveAbscract()
        {
            Console.WriteLine("This Motocycle is in drive!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a{GetType().BaseType.Name} that is virtually in drive");
        }
    }
}
