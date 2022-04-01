using AbstractFactoryTask.Cars;
using AbstractFactoryTask.Cars.AbstractCarTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTask.Factories.CarFactoryTypes
{
    public class AmericanFactory : CarFactory
    {
        public override FamilyCar CreateFamilyCar()
        {
            return new FordMondeo();
        }

        public override SportCar CreateSportCar()
        {
            return new DodgeChallenger();
        }
    }
}
