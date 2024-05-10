using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.FrontEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hrac steve = new Hrac("Steve", "Berseker", 0, 0, 0);
            MessageBox.Show(steve.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NPC alex = new NPC("Alex", 0, true);
            MessageBox.Show(alex.ToString());
        }
    }
}
