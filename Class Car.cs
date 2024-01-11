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
        public int Forward = 60;
        public int Backward = -5;
        public int Stop = 0;

        public void Movie()
        {
            if (this.Forward >= 60)
            {
                Console.WriteLine("Машина едет со скоростью 60 или более километров в час "); 
            }
            if (this.Backward == -5)
            {
                Console.WriteLine("Машина едет назад ");
            }
            if (this.Stop == 0)
            {
                Console.WriteLine("Машина стоит");
            }                    
            
        } 

    }
}
