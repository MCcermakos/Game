using Game.FrontEnd;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;

namespace Game.Tests
{
    [TestClass]
    public class TestsHrace
    {
        public Hrac hrac;

        [TestMethod]
        public void SpecializaceBereSpravneStringy()
        {
            hrac = new Hrac("Steve", "Berserker", 0, 0, 0);
            Assert.AreEqual("Berserker", hrac.Specializace);

            hrac = new Hrac("Steve", "Kouzelnik", 0, 0, 0);
            Assert.AreEqual("Kouzelnik", hrac.Specializace);

            hrac = new Hrac("Steve", "Inzenyr", 0, 0, 0);
            Assert.AreEqual("Inzenyr", hrac.Specializace);

            hrac = new Hrac("Steve", "Cizak", 0, 0, 0);
            Assert.AreEqual("Cizak", hrac.Specializace);
        }

        [TestMethod]
        public void SpecializaceNebereJineStringy()
        {
            hrac = new Hrac("Steve", "TestHeple", 0, 0, 0);
            Assert.AreNotSame("TestHeple", hrac.Specializace);
        }

        [TestMethod]
        public void PridavaniXP()
        {
            hrac = new Hrac("Steve", "Berseker", 0, 0, 0);

            hrac.PridejXP(50);
            Assert.AreEqual(50, hrac.xp);
        }

        [TestMethod]
        public void LevelUP()
        {
            hrac = new Hrac("Steve", "Berseker", 0, 0, 0);

            hrac.PridejXP(100);

            Assert.AreEqual(2, hrac.level);
        }

        [TestMethod]
        public void SpravnaInicializace()
        {
            hrac = new Hrac("Steve", "Berseker", 0, 0, 0);

            Assert.AreEqual(0, (int)hrac.oblicej);
            Assert.AreEqual(0, (int)hrac.vlasy);
            Assert.AreEqual(0, (int)hrac.barva);
        }
    }
}
