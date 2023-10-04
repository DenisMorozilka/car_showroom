using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_showroom.Strategies
{
    public class УАЗ_Hunter : showroom
    {
        void showroom.Price()
        {
            int t = 1290000;
            Console.WriteLine("Выбрана УАЗ Hunter");
            Console.WriteLine($"стоимость данной машины={t}");

        }
    }
}
