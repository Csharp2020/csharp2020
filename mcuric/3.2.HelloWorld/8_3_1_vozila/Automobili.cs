using System;
using System.Collections.Generic;
using System.Text;

namespace _8_3_1_vozila
{
    class Automobili:System.Collections.CollectionBase
    {
        public int Add(object automobil)
        {
            return base.InnerList.Add(automobil);
        }
        public void Remove(object automobil)
        {
            base.InnerList.Remove(automobil);
        }
        public object this[int index]
        {
            get
            {
                return (Automobil)base.InnerList[index];
            }
        }
    }
}
