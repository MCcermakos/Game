using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.FrontEnd
{
    public class Hrac : HerniPostava
    {
        private string specializace; 
        public enum Oblicej { VelkyNos, Ušoplesk, MakeUs };
        public Oblicej oblicej = 0;
        public enum Vlasy { drdol, culik, pleska };
        public Vlasy vlasy = 0;
        public enum BarvaVlasu {kastanova, cervena, blond};
        public BarvaVlasu barva = 0;
        public int xp = 0;
        public string Specializace
        {
            get 
            { 
                return specializace; 
            } 
            set 
            { 
                switch(value) 
                {
                    case "Kouzelnik": specializace = value; break;
                    case "Berserker": specializace = value; break;
                    case "Inzenyr": specializace = value; break;
                    case "Cizak": specializace = value; break;
                }
            }
        }

        public Hrac(string jmeno, string specializace, Oblicej oblicej, Vlasy vlasy, BarvaVlasu barvavlasu) : base(jmeno)
        {
            Specializace = specializace;
            this.oblicej = oblicej;
            this.vlasy = vlasy;
            this.barva = barvavlasu;
        }

        public void PridejXP(int xp)
        {
            this.xp += xp;
            if (this.xp >= 100 * base.level) base.level++;
        }

        public override string ToString()
        {
            string s = specializace + "\n Xp" + xp + "\n oblicej" + oblicej + "\n typ vlasu" + vlasy + "\n barva vlasu " + barva;
            return s;
        }
    }
}
