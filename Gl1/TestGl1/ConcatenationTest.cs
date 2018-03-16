using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aosk.CellSpace;
using Aosk;
using System.IO;
using Aosk.TermSpace;
using Aosk.TermSpace.TypeValeurs;

namespace TestAosk
{
    /// <summary>
    /// Description résumée pour FileManagerTest
    /// </summary>
    [TestClass]
    public class FileManagerTest
    {
        //cell1
        private string value1;
        private ulong row1;
        private ulong column1;
        private Numeric valueNumeric1;
        private CellCoord name1;
        private Expression exp1;
        private Cell cell1;
        //cell2
        private string value2;
        private ulong row2;
        private ulong column2;
        private Numeric valueNumeric2;
        private CellCoord name2;
        private Expression exp2;
        private Cell cell2;
        //conteneur
        private Cell[] conteneur;

        //appelle de fonction SaveFile de file manager
        private string path;
        private FileManager fileM;

        /// <summary>
        /// initialisation les attributs de la classe test
        /// </summary>
        [TestInitialize()]
        public void Initialize()
        {
            //cell1
            this.value1 = "11";
            this.row1 = 0;
            this.column1 = 0;
            this.valueNumeric1 = new Numeric(value1);
            this.name1 = new CellCoord(row1, column1);
            this.exp1 = new Expression(valueNumeric1);
            this.cell1 = new Cell(name1, exp1);
            //cell2
            string value2 = "22";
            this.row2 = 0;
            this.column2 = 1;
            this.valueNumeric2 = new Numeric(value2);
            this.name2 = new CellCoord(row2, column2);
            this.exp2 = new Expression(valueNumeric2);
            this.cell2 = new Cell(name2, exp2);
            //conteneur
            //conteneur
            this.conteneur = new Cell[2];
            this.conteneur[0] = cell1;
            this.conteneur[1] = cell2;

            //appelle de fonction SaveFile de file manager
            this.path = "fileSave";
            this.fileM = new FileManager();
        }

        /// <summary>
        /// Cleanup nettoie les objets creer
        /// </summary>
        [TestCleanup()]
        public void Cleanup()
        {
            //cell1
            this.valueNumeric1 = null;
            this.exp1 = null;
            this.cell1 = null;

            //cell2
            this.valueNumeric2 = null;
            this.exp2 = null;
            this.cell2 = null;

            //conteneur
            this.conteneur = new Cell[2];

            //appelle de fonction SaveFile de file manager
            this.path = null;
        }

        /// <summary>
        /// SaveFile teste la methode save de la classe file
        /// </summary>
        [TestMethod]
        public void SaveFile()
        {
            this.fileM.SaveFile(conteneur, path);

            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamReader sw = new StreamReader(path))
                {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        string line1 = "";
                        string line2 = "";
                        string chaine1 = "" + this.cell1.Name.Colonne + "@" + cell1.Name.Ligne + "<-" + cell1.GetExpression().GetData();
                        string chaine2 = "" + cell2.Name.Colonne + "@" + cell2.Name.Ligne + "<-" + cell2.GetExpression().GetData();
                        if ((line1 = sr.ReadLine()) != null)
                            Assert.AreEqual(line1, chaine1);

                        if ((line2 = sr.ReadLine()) != null)
                            Assert.AreEqual(line2, chaine2);
                    }
                }
            }
        }



        /// <summary>
        /// ExportFile la methode export de la classe file manager
        /// </summary>
        [TestMethod]
        public void ExportFile()
        {
            fileM.ExportFile(conteneur, path);

            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamReader sr = File.OpenText(path))
                {
                    string line1 = "";
                    string line2 = "";

                    if ((line1 = sr.ReadLine()) != null)
                    {
                        string[] tabline1 = line1.Split(',');
                        string chaine1 = cell1.GetExpression().CalculVal();
                        Assert.AreEqual(tabline1[0], chaine1);
                    }


                    if ((line2 = sr.ReadLine()) != null)
                    {
                        string[] tabline2 = line2.Split(',');
                        string chaine2 = cell2.GetExpression().CalculVal();
                        Assert.AreEqual(tabline2[0], chaine2);
                    }

                }

            }
        }

        /// <summary>
        ///OpenFile la methode open de la classe file manager
        /// </summary>
        [TestMethod]
        public void OpenFile()
        {
            string Chaine1 = "";
            string Chaine2 = "";
            Chaine2 = this.fileM.OpenFile(path);

            Assert.AreNotEqual(Chaine1, Chaine2);

        }

        /// <summary>
        /// importFile la methode import de la classe file manager
        /// </summary>
        [TestMethod]
        public void importFile()
        {
            string Chaine1 = "";
            string Chaine2 = "";
            Chaine2 = this.fileM.ImportFile(path);
            Assert.AreNotEqual(Chaine1, Chaine2);
        }


    }
}