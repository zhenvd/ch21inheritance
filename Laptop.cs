using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Laptop : Computer
    {
        public double batteryLife { get; set; } = 50.0;

        public Laptop(bool physicalKeyboard, int screenSize, string model, string OS) : base(physicalKeyboard, screenSize, model, OS)
        {

        }
        public void chargeBattery()
        {
            batteryLife++;
        }


    }
}
