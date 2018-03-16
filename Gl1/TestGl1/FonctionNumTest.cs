using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aosk.TermSpace.TypeValeurs;
using Aosk.TermSpace.Fonctions.Numerique;
using Aosk.TermSpace.Fonctions.Numerique.Trigonometrie;

namespace TestAosk
{
    /// <summary>
    /// Description résumée pour PlusTest
    /// </summary>
    [TestClass]
    public class FonctionNumTest
    {

        private Absolu ab;
        private Arrondi ar;
        private Moyenne moy;
        private Puissance p;
        private Racine r;
        private Atan at;
        private Cosinus cos;
        private Tangente tan;
        private ToDegree tod;
        private ToRadiant tor;

        public FonctionNumTest()
        {
            Numeric[] val1 = new Numeric[1];
            Numeric[] val2 = new Numeric[2];
            val1[0] = new Numeric("9");
            val2[0] = new Numeric("9");
            val2[1] = new Numeric("2");
            ab = new Absolu(val1);
            ar = new Arrondi(val1);
            moy = new Moyenne(val2);
            p = new Puissance(val2);
            r = new Racine(val1);
            at = new Atan(val1);
            cos = new Cosinus(val1);
            tan = new Tangente(val1);
            tod = new ToDegree(val1);
            tor = new ToRadiant(val1);
        }

        [TestMethod]
        public void AbsoluInterpreteTest()
        {
            Assert.AreEqual("9", ab.Interpret().ToString());
        }

        [TestMethod]
        public void AbsoluToStringTest()
        {
            Assert.AreEqual("abs(9)", ab.ToString());
        }

        [TestMethod]
        public void ArrondiTest()
        {
            Assert.AreEqual("9", ar.Interpret().ToString());
        }

        [TestMethod]
        public void MoyenneTest()
        {
            Assert.AreEqual("5.5", moy.Interpret().ToString());
        }

        [TestMethod]
        public void PuissanceTest()
        {
            Assert.AreEqual("81", p.Interpret().ToString());
        }

        [TestMethod]
        public void RacineTest()
        {
            Assert.AreEqual("3", r.Interpret().ToString());
        }

        [TestMethod]
        public void AtanTest()
        {
            Assert.AreEqual("1.460139105621", at.Interpret().ToString());
        }

        [TestMethod]
        public void CosinusTest()
        {
            Assert.AreEqual("-0.911130261884677", cos.Interpret().ToString());
        }

        [TestMethod]
        public void TangenteTest()
        {
            Assert.AreEqual("-0.45231565944181", tan.Interpret().ToString());
        }

        [TestMethod]
        public void ToDegreeTest()
        {
            Assert.AreEqual("515.662015617741", tod.Interpret().ToString());
        }

        [TestMethod]
        public void ToRadianTest()
        {
            Assert.AreEqual("0.15707963267949", tor.Interpret().ToString());
        }

    }
}
