using System;
using System.Collections;

namespace _8_Vocarna
{
    internal class Apples : CollectionBase, IApples
    {
        private double ukupnaTezina;
        public Apples()
        {
        }
        internal int Add(Apple aaa)
        {
            ukupnaTezina += aaa.Tezina;
            return InnerList.Add(aaa);
        }

        internal void Remove(Apple aaa)
        {
            ukupnaTezina -= aaa.Tezina;
            InnerList.Remove(aaa);
        }
        // ovime dobivamo mogućnost ispisa foreach
        public Apple this[int index]
        {
            get => (Apple)InnerList[index];
        }

        internal void ispis()
        {
            Console.WriteLine($"Košara s jabukama, količina:{InnerList.Count} Ukupna težina:{ukupnaTezina / 1000} kg");
            foreach (Apple item in InnerList)
            {
                Console.WriteLine($"Jabuka:{item.Tezina}");
            }
        }

        public string MjenjajBoju(string boja)
        {
            return $"Boja je{boja}";
        }
    }
}