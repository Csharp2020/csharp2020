using System;
using System.Collections;

namespace lista_parni_i_neparni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unos u listu parni neparni");
            
            int x = 0;
            ArrayList lista_parni = new ArrayList();
            ArrayList lista_neparni = new ArrayList();

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Unesi {0} elemnt niza: ", i);
                x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                {
                    lista_parni.Add(x);
                } else
                {
                    lista_neparni.Add(x);
                }
                
            }
            Console.WriteLine("Parni brojevi su: ");
            for (int i = 0; i < lista_parni.Count; i++)
            {

                Console.WriteLine(lista_parni[i]);
            }

            Console.WriteLine("Neparni brojevi su: ");
            for (int i = 0; i < lista_neparni.Count; i++)
            {

                Console.WriteLine(lista_neparni[i]);
            }
        }
    }
}
