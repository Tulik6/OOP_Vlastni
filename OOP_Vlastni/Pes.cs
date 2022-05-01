using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vlastni
{
    class Pes : Zvire
    {
        private string plemeno;
        public Pes(string nazev, string typ, string plemeno) : base(nazev, typ)   
        {
            this.plemeno = plemeno;
        }

        public string GetPlemeno()
        {
            return plemeno;
        }

        public void SetPlemeno(string plemeno)
        {
            this.plemeno = plemeno;
        }
    }
}
