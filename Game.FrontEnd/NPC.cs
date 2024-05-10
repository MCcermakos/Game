using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.FrontEnd
{
    public class NPC : HerniPostava
    {
        public enum Prace { obchodnik, nepritel, obyvatel};
        public Prace prace = 0;
        public bool sila;
        public NPC(string jmeno, Prace prace) : base(jmeno)
        {
            this.prace = prace;
            this.sila = false;
        }
        public NPC(string jmeno, Prace prace, bool sila) : base(jmeno)
        {
            this.prace = prace;
            this.sila = sila;
        }

        public override void ZmenaPozice(double poziceX, double poziceY)
        {
            base.ZmenaPozice(poziceX, poziceY);
        }

        public override string ToString()
        {
            string s;
            if (sila)
             s = Jmeno + "\n prace " + prace.ToString() + "\n je boss";
            else s = Jmeno + "\n prace " + prace.ToString() + "\n  neni boss";
            return s;
        }
    }
}
