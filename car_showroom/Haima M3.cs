using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_showroom.Strategies
{
    public class Haima_M3 : showroom
    {
        void showroom.Price()
        {
            int t = 479100;
            Console.WriteLine("Выбрана Haima M3");
            Console.WriteLine($"стоимость данной машины={0:С4}");

        }
    }
}