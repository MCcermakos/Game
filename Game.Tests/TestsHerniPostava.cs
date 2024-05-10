using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Game.Tests
{
    [TestClass]
    public class TestsHerniPostava
    {
        private HerniPostava herniPostava;

        [TestMethod]
        public void JmenoMocDlouhe()
        {
            herniPostava = new HerniPostava("01234567890123456");

            Assert.IsTrue(herniPostava.jmeno.isNull());
        }

        [TestMethod]
        public void SpravnaInicializace()
        {
            herniPostava = new HerniPostava("01234567890123456");

            Assert.IsTrue(herniPostava.level == 1);
            Assert.IsTrue(herniPostava.poziceX == 0);
            Assert.IsTrue(herniPostava.poziceY == 0);
        }

        [TestMethod]
        public void ZmenaPozice()
        {
            herniPostava = new HerniPostava("01234567890123456");

            herniPostava.ZmenaPozice(2.56, 2.57);

            Assert.IsTrue(herniPostava.poziceX == 2.56);
            Assert.IsTrue(herniPostava.poziceY == 2.57);
        }
    }
}
