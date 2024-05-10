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
        private NPC npc;

        [TestMethod]
        public void ZmenaPoziceNefunguje()
        {
            npc = new NPC(100, 100);

            npc.ZmenaPozice(10, 10);

            Assert.AreEqual(100, npc.poziceX);
            Assert.AreEqual(100, npc.poziceY);
        }

        [TestMethod]
        public void JeBoss()
        {
            npc = new NPC(10, 10, 10); // je boss

            Assert.IsTrue(npc.isBoss);

            npc = new NPC(10, 10); // neni boss

            Assert.IsFalse(npc.isBoss);
        }

    }
}
