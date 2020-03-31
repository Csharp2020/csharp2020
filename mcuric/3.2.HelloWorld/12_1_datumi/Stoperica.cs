using System;
using System.Collections.Generic;
using System.Text;

namespace _12_1_datumi
{
    class Stoperica
    {
        DateTime pocetak;
        DateTime kraj;
        public DateTime Pocetak { get {
                return pocetak;
            }
            set {
                pocetak = value;
                if(pocetak != null)
                {
                    StopericaStart(this, new EventArgs());
                }
            } }
        public DateTime Kraj
        {
            get
            {
                return kraj;
            }
            set
            {
                kraj = value;
                if (kraj != null)
                {
                    StopericaStop(this, new EventArgs());
                }
            }
        }

        public delegate void StopericaStartDelegat(object sender, EventArgs e);
        public event StopericaStartDelegat StopericaStart;
        public delegate void StopericaStopDelegat(object sender, EventArgs e);
        public event StopericaStopDelegat StopericaStop;
    }
}
