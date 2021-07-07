using System;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop alienware = new Laptop(true, 15, "alienware", "Windows");
            SmartPhone samsung = new SmartPhone(false, 5, "Apple", "Android");
            /*samsung.batteryLife = 70;
            alienware.batteryLife = 80;
            alienware.CurrentOSVersion();
            alienware.OSUpdate();
            alienware.CurrentOSVersion();
            samsung.batteryStatus();
            samsung.takePicture();
            samsung.batteryStatus();*/
            Console.WriteLine(alienware.ID);
            Console.WriteLine(samsung.ID);
            //AbstractEntity test = new AbstractEntity();



        }
    }
}
