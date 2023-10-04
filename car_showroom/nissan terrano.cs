using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_showroom.Strategies
{
    public class Nissan_Terrano : showroom
    {
        void showroom.Price()
        {
            int t = 350000;
            Console.WriteLine("Выбрана nissan terrano");

            Console.WriteLine($"Cтоимость данной машины={t}");

        }
    }
}