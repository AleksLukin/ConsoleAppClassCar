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
            Console.Write("Введите скорость с которой едет машина: ");
            string s = Console.ReadLine();

            int.TryParse(s, out int result);

            Class_Car car = new Class_Car();
            car.Movie(result);

            Console.ReadLine();
        }
    }
}
