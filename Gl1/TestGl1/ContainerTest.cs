using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aosk.CellSpace;
using System.Collections.Generic;
using Aosk.TermSpace.TypeValeurs;

namespace TestAosk
{
    [TestClass]
    public class ContainerTest
    {

        private Container c;
        private Cell c1;
        private Cell c2;

        [TestInitialize()]
        public void Initialize()
        {
            this.c = new Container();
            c1 = new Cell(new CellCoord(5, 3), new Expression(new Numeric("abc")));
            c2 = new Cell(new CellCoord(1, 2), new Expression(new Numeric("def")));
            this.c.AddCell(c1);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            this.c = null;
            this.c1 = null;
            this.c2 = null;
        }

        [TestMethod]
        public void AddCellTest()
        {
            Assert.IsTrue(c.ExisteCell(c1.Name));
        }

        [TestMethod]
        public void DeleteCellTest()
        {
            c.DeleteCell(c1);
            Assert.IsFalse(c.ExisteCell(c1.Name));
        }

        [TestMethod]
        public void SearchCellTest()
        {
            c2 = c.SearchCell(c1.Name);
            Assert.AreEqual(c1, c2);
        }

    }
}
