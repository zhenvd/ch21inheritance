using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Computer : AbstractEntity
    {

        public bool PhysicalKeyboard { get; set; }
        public int ScreenSize { get; set; }
        public string Model { get; set; }
        public string OS { get; set; }
        public string OSVersion { get; set; }
        public int version { get; set; } = 1;

        public Computer() {
            //Console.WriteLine("Computer constructor is called");
        }

        public Computer(bool PhysicalKeyboard, int ScreenSize, string Model, string OS)
        {
           this.PhysicalKeyboard = PhysicalKeyboard;
           this.ScreenSize = ScreenSize;
           this.Model = Model;
           this.OS = OS;
        }

        public Computer (string operatingsystem)
        {
            OS = operatingsystem;
            if (String.IsNullOrEmpty(OS))
            {
                throw new ArgumentNullException(OS, "Operating System required.");
            }
        }

        public void CurrentOSVersion()
        {

            Console.WriteLine($"{OS} {version}");
        }

        public void OSUpdate()
        {
            version++;
            OSVersion = $"{this.OS} {this.version}";
        }

    }
}
