using AbstractFactoryTask.Cars.AbstractCarTypes;
using AbstractFactoryTask.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTask
{
    public class RaceTrack
    {
        private FamilyCar familyCar;
        private SportCar sportCar;

        public RaceTrack(CarFactory carFactory)
        {
            familyCar = carFactory.CreateFamilyCar();
            sportCar = carFactory.CreateSportCar();
        }

        public void StartRace()
        {
            sportCar.Overtake(familyCar);
        }
    }
}
