using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_showroom.Strategies
{
    public class Volkswagen_Polo : showroom
    {
        void showroom.Price()
        {
            int t = 1621000;
            Console.WriteLine("Выбрана Volkswagen Polo");
            Console.WriteLine($"стоимость данной машины={t}");

        }
    }
}
