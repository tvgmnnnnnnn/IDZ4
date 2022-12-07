using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz4_opp
{
    internal class ГрузовойАвтомобиль : Автомобиль
    {
        protected float loadCapacity;

        public ГрузовойАвтомобиль(string pName, int pPrice, int pMaxSpeed, float pLoadCapacity) : base(pName, pPrice, pMaxSpeed)
        {
            this.loadCapacity = pLoadCapacity;
        }
        override public string GetName()
        {
            return name + " Максимальная скорость грузовика: " + maxSpeed.ToString();
        }
    }
}
