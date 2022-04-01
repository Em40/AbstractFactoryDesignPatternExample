using AbstractFactoryTask.Cars.AbstractCarTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTask.Cars
{
    public class DodgeChallenger : SportCar
    {
        public override void Overtake(FamilyCar familyCar)
        {
            Console.WriteLine(this.GetType().Name + " overtakes " + familyCar.GetType().Name);
        }
    }
}
