using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_showroom.Strategies
{
    public class Renault_Logan : showroom
    {
        void showroom.Price()
        {
            int t = 1370777;
            Console.WriteLine("Выбрана Renault Logan");
            Console.WriteLine($"стоимость данной машины={t}");

        }
    }
}