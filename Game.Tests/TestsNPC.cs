using Game.FrontEnd;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Tests
{
    [TestClass]
    public class TestsNPC
    {
        public NPC npc;

        [TestMethod]
        public void ZmenaPoziceNefunguje()
        {
            npc = new NPC("steve",0, true);

            npc.ZmenaPozice(10.0, 10.0);

            Assert.AreEqual(10, npc.PoziceX);
            Assert.AreEqual(10, npc.PoziceY);
        }

        [TestMethod]
        public void JeBoss()
        {
            npc = new NPC("steve", 0, true); // je boss

            Assert.IsTrue(npc.sila);

            npc = new NPC("steve", 0); // neni boss

            Assert.IsFalse(npc.sila);
        }

    }
}
