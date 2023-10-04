using System;
using car;
using car_showroom;
using car_showroom.Strategies;

Worker worker = new("Василий");
worker.Setshowroom(new Nissan_Terrano());
worker.choice();
Console.ReadLine();

