using AbstractFactoryTask.Factories;
using AbstractFactoryTask.Factories.CarFactoryTypes;
using System;

namespace AbstractFactoryTask
{
    public class StartUp
    {
        public static void Main()
        {
            CarFactory americanFactory = new AmericanFactory();
            RaceTrack americanRaceTrack = new RaceTrack(americanFactory);
            americanRaceTrack.StartRace();

            Console.WriteLine();

            CarFactory germanFactory = new GermanFactory();
            RaceTrack germanRaceTrack = new RaceTrack(germanFactory);
            germanRaceTrack.StartRace();
        }
    }
}
