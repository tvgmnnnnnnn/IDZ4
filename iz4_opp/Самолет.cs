﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz4_opp
{
    internal class Самолет : Авиасредство
    {
        protected int maxCapacity;
        public Самолет(string pName, int pReseaseYear, int pMaxHeight, int pMaxCapacity) : base(pName, pReseaseYear, pMaxHeight)
        {
            maxCapacity = pMaxCapacity;
        }
        override public string GetName()
        {
            return name + " Максимальная высота полета данного самолета: " + maxHeight.ToString();
        }
    }
}
