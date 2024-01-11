using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClassCar
{
    internal class Class_Car
    {
        private int Speed;

        public void Forward()
        {
            Speed = 60;
        }
        public void Backward() 
        {
            Speed = -5;
        }
        public void Stop()
        {
            Speed = 0;
        }
        public void PrintSpeed()
        {
            if (Speed > 0)
            {
                Console.WriteLine("Машина едет вперед");
            }
            if (Speed < 0)
            {
                Console.WriteLine("Машина едет назад");
            }
            if (Speed == 0)
            {
                Console.WriteLine("Машина стоит");
            }
        }

    }
}
