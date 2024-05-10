using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public class HerniPostava
    {
        public string jmeno;
        public int level = 1;
        protected double poziceX = 0;
        protected double poziceY = 0;
        public string Jmeno
        {
            get
            {
                return jmeno;
            }
            set
            {
                if (value.Length <= 10) jmeno = value;
                else MessageBox.Show("Příliš dlouhé jméno");
            }
        }

        public double PoziceX
        {
            get { return poziceX; }
        }
         public double PoziceY
        { 
            get { return poziceY; } 
        }

        public HerniPostava(string jmeno) 
        { 
            Jmeno = jmeno;
        }

         public virtual void ZmenaPozice(double poziceX, double poziceY)
         {
            this.poziceX = poziceX;
            this.poziceY = poziceY;

         }

        public override string ToString()
        {
            string s = Jmeno + "\n level: " + level + "\n pozice: " + PoziceX + ";" + PoziceY;
            return s;
        }
    }
}
