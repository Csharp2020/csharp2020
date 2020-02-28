﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _8_3_1_vozila
{
    class Automobili : CollectionBase
    {
        internal int Add(Automobil a1)
        {
            return InnerList.Add(a1);
        }

        internal void Remove(Automobil a1)
        {
           InnerList.Remove(a1);
        }

        // ovime dobivamo mogućnosti ispisa foreach
        public Automobil this[int index]
        {
            get => (Automobil)InnerList[index];
        }
    }
}
