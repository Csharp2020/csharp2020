using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak_voce
{
    class Apples:System.Collections.CollectionBase
    {
        public int Add(object apple)
        {
            return base.InnerList.Add(apple);
        }
        public void Remove(object apple)
        {
            base.InnerList.Remove(apple);
        }
        public object this[int index]
        {
            get
            {
                return (Apple)base.InnerList[index];
            }
        }
    }
}
