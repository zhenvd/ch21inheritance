using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class SmartPhone : Laptop
    {
        //private double BatteryLife;
        static double batteryDead = 0.0;
        public readonly string BrandName = "Samsung";

        public SmartPhone(bool physicalKeyboard, int screenSize, string brandName, string OS) : base(physicalKeyboard, screenSize, brandName, OS)
        {
            BrandName = brandName;
        }

        /*public double batteryLife
        {
            get { return = batteryLife; }
            set { batteryLife = value; }
        }*/
        public void takePicture()
        {
            batteryLife--;
        }

        public void batteryStatus()
        {
            if(batteryLife > 21)
            {
                Console.WriteLine($"Battery is currently at {batteryLife}%.");
            }
            else if(batteryLife > 0)
            {
                Console.WriteLine($"Battery is currently at {batteryLife}%. Please charge your phone.");
            }
            else
            {
                Console.WriteLine($"Battery is currently at {batteryDead}%. Your battery is dead.");
            }
        }
    }
}
