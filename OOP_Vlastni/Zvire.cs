using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace OOP_Vlastni
{
    class Zvire
    {
        protected string nazev;
        protected string typ;
        protected int krmivo;
        public string Nazev
        {
            get
            {
                return nazev;
            }

            private set
            {
                nazev = value;
            }
        }

        public string Typ
        {
            get
            {
                return typ;
            }

            set
            {
                string p = value;
                if (p == "Domácí" || p == "Hospodářské" || p == "Divoké")
                {
                    typ = p;
                }
                else MessageBox.Show("Špatně zadaný typ zvířete");
            }
        }

        public Zvire(string nazev, string typ)
        {
            this.nazev = nazev;
            Typ = typ;
        }

        public int GetKrmivo()
        {
            return krmivo;
        }

        public void SetKrmivo(int krmivo)
        {
            this.krmivo = krmivo; 
        }

        public void Jez()
        {
            if (krmivo > 0)
            {
                MessageBox.Show("Zvíře se najedlo");
                krmivo--;
            }
            else MessageBox.Show("Zvíře nemá krmivo :("); 
        }

        public override string ToString()
        {
            string p = "Zvíře: " + nazev +
                "\nTyp: " + typ +
                "\nMnožství krmiva: " + krmivo +
            return p;
        }

    }
}
