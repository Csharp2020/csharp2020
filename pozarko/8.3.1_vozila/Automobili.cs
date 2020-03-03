using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _8._3._1_vozila
{
    class Automobili:CollectionBase
    {
        internal int Add(Automobil a1)
        {
            return InnerList.Add(a1);
        }

        internal void Remove(Automobil a1)
        {
            InnerList.Remove(a1);
        }


        
        public Automobil this[int index]
        {
            get => (Automobil)InnerList[index];
        }
    }
}
