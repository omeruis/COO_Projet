using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aosk.ParserSpace;

namespace TestAosk
{
    /// <summary>
    /// Description résumée pour UnitTest1
    /// </summary>
    [TestClass]
    public class ParserTest
    {
        private Kernel kern;
        private Parser pars;

        [TestInitialize()]
        public void Initialize()
        {
            this.kern = new Kernel();
            this.pars = new Parser(kern);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            this.kern = null;
            this.pars = null;
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
        public void AnalyseInsertTest()
        {
            string msg = kern.interact("1@2<-3+5;");
            string res = "Insert Success";
            Assert.AreEqual(msg,res);

        }

        [TestMethod]
        public void AnalyseReadTest()
        {
            kern.interact("1@2<-3+5;");
            string msg = kern.interact("read 1@2;");
            string res = "8";
            Assert.AreEqual(msg, res);
        }
    }
}
