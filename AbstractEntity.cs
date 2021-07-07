using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public abstract class AbstractEntity
    {
        public static int counter = 0;
        private int id = 0;

        public int ID
        {
            get { return id; }
        }
        public AbstractEntity()
        {
            Console.WriteLine($"Main constructor is called");
            counter++;
            this.id = counter;
        }
    }
}
