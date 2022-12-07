using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz4_opp
{
    internal class Авиасредство : ТехСредство
    {
        protected int maxHeight;
        public Авиасредство(string pName, int pPrice, int pMaxHeight) : base(pName, pPrice)
        {
            maxHeight = pMaxHeight;
        }

        override public string GetName()
        {
            return name + " Максимальная высота полета: " + maxHeight.ToString();
        }
    }
}
