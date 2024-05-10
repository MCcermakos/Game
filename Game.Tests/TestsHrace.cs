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
            hrac = new Hrac("Berserker");
            Assert.AreEqual("Berserker", hrac.Specializace);

            hrac = new Hrac("Kouzelnik");
            Assert.AreEqual("Kouzelnik", hrac.Specializace);

            hrac = new Hrac("Inzenyr");
            Assert.AreEqual("Inzenyr", hrac.Specializace);

            hrac = new Hrac("Cizak");
            Assert.AreEqual("Cizak", hrac.Specializace);
        }

        [TestMethod]
        public void SpecializaceNebereJineStringy()
        {
            hrac = new Hrac("TestHeple");
            Assert.AreNotSame("TestHeple", hrac.Specializace);
        }

        [TestMethod]
        public void PridavaniXP()
        {
            hrac = new Hrac();

            hrac.PridejXP(50);
            Assert.AreEqual(50, hrac.XP);
        }

        [TestMethod]
        public void LevelUP()
        {
            hrac = new Hrac();

            hrac.PridejXP(100);

            Assert.AreEqual(1, hrac.Level);
        }

        [TestMethod]
        public void SpravnaInicializace()
        {
            hrac = new Hrac();

            Assert.AreEqual(0, hrac.oblicej);
            Assert.AreEqual(0, hrac.vlasy);
            Assert.AreEqual(0, hrac.barvaVlasu);
        }
    }
}
