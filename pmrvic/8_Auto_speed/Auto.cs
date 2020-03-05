using System;
using System.Collections.Generic;

namespace _8_Auto_speed
{
    public class Auto
    {
        private string marka;
        private string model;
        private int KS = 0;
        private double trenutnaBrzina = 0;
        private double maxbrzina = 0;  
        private int curtime = 0;

        public List<Point> dijagramBrzine = new List<Point> { };

        public Auto(string marka, string model, int KS)
        {
            this.marka = marka;
            this.model = model;
            this.KS = KS;
            maxbrzina = KS*2;  // stavi neki faktor, 
        }


        public void Ubrzaj(int acc_level, int acc_time)
        {
            double tempspeed = 0;
            double faktorubrzanja = (acc_level / 10);
            for (int i=1; i < acc_time; i++)
            {
                //        =   povećanje    *      f(t)       *   skaliranje            +  početna     
                tempspeed = faktorubrzanja * funkUbrzanja(i) * ((maxbrzina-trenutnaBrzina) / maxbrzina) + trenutnaBrzina;
                dijagramBrzine.Add(new Point(i + this.curtime, (int)tempspeed));
            }
            this.curtime += acc_time;
            trenutnaBrzina = tempspeed;

        }
        internal int funkUbrzanja(int sekunda)
        {
            return (int)(Math.Atan(0.3 * sekunda) * (2 / Math.PI) * maxbrzina);
        }
    }
}