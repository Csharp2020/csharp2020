using System;

namespace _8_Vocarna
{
    internal class Voce : IVoce
    {
        private string boja;
        public delegate void del_promjena_boje(object sender, EventArgs e);
        public event del_promjena_boje PromjenaBoje;

        public string Boja
        {
            get => boja;
            set
            {
                boja = value;
                PromjenaBoje?.Invoke(this, new EventArgs());
            }
        }
    }
}