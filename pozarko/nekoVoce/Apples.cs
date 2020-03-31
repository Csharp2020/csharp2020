using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace nekoVoce
{
    class Apples:CollectionBase
    {
        internal int Add(Apple a1)
        {
            return InnerList.Add(a1);
        }

        public Apple this[int index]
        {
            get => (Apple)InnerList[index];
        }

        internal void ispis(Apple x)
        {
            Console.WriteLine(x);
        }
    }
}
