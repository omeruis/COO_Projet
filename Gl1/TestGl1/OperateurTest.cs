using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aosk.TermSpace.Operateur;
using Aosk.TermSpace.TypeValeurs;

namespace TestAosk
{
    /// <summary>
    /// Description résumée pour OperateurTest
    /// </summary>
    [TestClass]
    public class OperateurTest
    {
        private Div d;
        private Minus min;
        private Modulo mod;
        private Mult mul;
        private Plus p;
        private Numeric[] val;

        public OperateurTest()
        {
            val = new Numeric[2];
            this.val[0] = new Numeric("6");
            this.val[1] = new Numeric("2");
            p = new Plus(this.val);
            mul = new Mult(this.val);
            mod = new Modulo(this.val);
            min = new Minus(this.val);
            d = new Div(this.val);
        }

        #region Attributs de tests supplémentaires
        //
        // Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        // Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test de la classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Utilisez ClassCleanup pour exécuter du code une fois que tous les tests d'une classe ont été exécutés
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void PlusInterpretTest()
        {
            Assert.AreEqual("8", p.Interpret().ToString());
        }

        [TestMethod]
        public void PlusToStringTest()
        {
            Assert.AreEqual("6+2", p.ToString());
        }

        [TestMethod]
        public void MultInterpretTest()
        {
            Assert.AreEqual("12", mul.Interpret().ToString());
        }

        [TestMethod]
        public void MultToStringTest()
        {
            Assert.AreEqual("6*2", mul.ToString());
        }

        [TestMethod]
        public void ModuloInterpretTest()
        { 
            Assert.AreEqual("0", mod.Interpret().ToString());
        }

        [TestMethod]
        public void ModuloToStringTest()
        {
            Assert.AreEqual("6%2", mod.ToString());
        }

        [TestMethod]
        public void MinusInterpretTest()
        {
            Assert.AreEqual("4", min.Interpret().ToString());
        }

        [TestMethod]
        public void MinusToStringTest()
        {
            Assert.AreEqual("6-2", min.ToString());
        }

        [TestMethod]
        public void DivInterpretTest()
        {
            Assert.AreEqual("3", d.Interpret().ToString());
        }

        [TestMethod]
        public void DivToStringTest()
        {
            Assert.AreEqual("6/2", d.ToString());
        }
    }
}
