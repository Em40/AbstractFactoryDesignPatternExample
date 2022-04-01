using AbstractFactoryTask.Cars.AbstractCarTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTask.Factories
{
    public abstract class CarFactory
    {
        public abstract FamilyCar CreateFamilyCar();

        public abstract SportCar CreateSportCar();
    }
}
