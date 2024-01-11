using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClassCar
{
    internal class Fuel
    {
        bool fuel;

        private void ReFuel()
        {
            Console.WriteLine("Машина незаправлена!");

            fuel = true;

            Console.WriteLine("Машина заправлена");
        }
        public void CarToGo()
        {
            if (!fuel)
            {
                ReFuel();
            }
            Console.WriteLine("Машина едет!");

            fuel = false;
        }
    }
}
