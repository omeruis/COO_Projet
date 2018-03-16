using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aosk.CellSpace;
using Aosk.TermSpace.TypeValeurs;

namespace TestAosk
{
    /// <summary>
    /// Description résumée pour UnitTest1
    /// </summary>

    [TestClass]
    public class KernelTest
    {
        private Kernel ker;

        [TestInitialize()]
        public void Initialize()
        {
            this.ker = new Kernel();
        }

        [TestCleanup()]
        public void Cleanup()
        {
            this.ker = null;
        }

        [TestMethod]
        public void TestPropagationDiagonal()
        {
            char concat = '"';
            String[] expected = new string[] { concat+"rototo" +concat, concat+"rototo" + concat, concat+"rototo" + concat, concat+"rototo" + concat };
            CellCoord cc1 = new CellCoord(0, 0);
            CellCoord cc2 = new CellCoord(1, 1);
            ker.InsertData(cc1, new Texte("rototo"));

            ker.Propage(cc2, cc1);
            string[] tab = new string[4];
            int y = 0;
            for(ulong i = 0; i <2; i++)
            {
                for(ulong j=0;j <2; j++)
                {
                    tab[y] = ker.Read(new CellCoord(i, j));
                    y++;
                }
            }
            CollectionAssert.AreEqual(expected, tab);
        }
    }
}
