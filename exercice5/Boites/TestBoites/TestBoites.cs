using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boites;

namespace TestBoites
{
    [TestClass]
    public class TestBoites
    {

        [TestMethod]
        public void TestCompteur()
        {
            Boite[] box = new Boite[4];
            for (int i = 0; i < 4; i++)
                box[i] = new Boite();
            Assert.AreEqual(4, Boite.CompteurBoite);
        }

        [TestMethod]
        public void TestVolume()
        {
            Boite box = new Boite(1, 5, 2);
            Assert.AreEqual(10, box.Volume);
        }
    }
}
