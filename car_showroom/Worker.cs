using car_showroom;
using car_showroom.Strategies;
using System;
using System.Threading;

namespace car
{
    public class Worker
    {
        public readonly string _name;
        public showroom _car;

        public Worker(string name)
        {
            _name = name;
        }

        public void Setshowroom(showroom car)
        {
            _car = car;
        }
        public void choice()
        {
            Console.WriteLine(">>>");
            if (_car is null)
            {
                Console.WriteLine($"{_name} выбирите пожалуйста машину");
                return;
            }
            else
                Console.Write($"");
            _car.price();
            Console.WriteLine($" {_name} начал подготавливать вашу машину");
            Thread.Sleep(2920);
            Console.WriteLine($" {_name} уже подготовили вашу машину.Вы можете её забрать");

        }
    }





}