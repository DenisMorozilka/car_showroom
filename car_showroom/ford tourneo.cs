using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_showroom.Strategies
{
    public class Ford_Tourneo_Custom : showroom
    {
        void showroom.Price()
        {
            int t = 250000;
            Console.WriteLine("Выбрана ford tourneo");
            Console.WriteLine($"стоимость данной машины={t}");
        }


    }



}
