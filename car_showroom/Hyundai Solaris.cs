using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_showroom.Strategies
{
    public class Hyundai_Solaris : showroom
    {
        void showroom.Price()
        {
            int t = 1408000;
            Console.WriteLine("Выбрана Hyundai Solaris");
            Console.WriteLine($"стоимость данной машины={t}");

        }
    }
}
