using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClassCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fuel fuel1 = new Fuel();
            fuel1.CarToGo();
            Class_Car car1 = new Class_Car();            
            car1.Stop();
            car1.PrintSpeed();
            car1.Forward();
            car1.PrintSpeed();
            car1.Stop();
            car1.PrintSpeed();

            Console.WriteLine();

            Fuel fuel2 = new Fuel();
            fuel2.CarToGo();
            Class_Car car2 = new Class_Car();            
            car2.Stop();
            car2.PrintSpeed();
            car2.Backward();
            car2.PrintSpeed();
            car2.Stop();
            car2.PrintSpeed();

            Console.ReadLine();
        }
    }
}
