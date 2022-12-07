using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz4_opp
{
    internal class ЛегковойАвтомобиль : Автомобиль
    {
        protected bool isAuto;
        public ЛегковойАвтомобиль(string pName, int pPrice, int pMaxSpeed, bool pIsAuto) : base(pName, pPrice, pMaxSpeed)
        {
            isAuto = pIsAuto;
        }
        override public string GetName()
        {
            return name + " Максимальная скорость легковой машины: " + maxSpeed.ToString();
        }
    }
}
