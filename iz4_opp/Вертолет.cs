using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz4_opp
{
    internal class Вертолет : Авиасредство
    {
        protected bool isMilitary;
        public Вертолет(string pName, int pReseaseYear, int pMaxHeight, bool pIsMilitary) : base(pName, pReseaseYear, pMaxHeight)
        {
            isMilitary = pIsMilitary;
        }
        override public string GetName()
        {
            return name + " Максимальная высота полета вертолета: " + maxHeight.ToString();
        }
    }
}
