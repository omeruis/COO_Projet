using System;
using System.IO;
using Aosk.CellSpace;
using System.Collections.Generic;
using Aosk.Exceptions;

namespace Aosk
{
    /// <summary>
    /// Objet gérant l'interaction avec les fichiers physiques
    /// </summary>
    public class FileManager
    {

        /// <summary>
        /// constructeur de la classe File Manager
        /// </summary>
        /// <param name="path">Le nom du fichier à enregistrer.</param>
        public FileManager()
        {
            this.helpPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDi‌​rectory, "..\\..\\..\\Doc\\help.txt"));
            this.savePath = "empty";
            this.exportPath = "empty";
        }

        /// <summary>
        /// sauvegarde les données dans un format proprietaire
        /// </summary>
        /// <param name="path">Le nom du fichier à enregistrer.</param>
        public void SaveFile(Cell[] contains, string path)
        {
            try
            {
                if (!path.Equals("empty"))
                {
                    this.savePath = path;
                }
                else if (this.savePath.Equals("empty"))
                {
                    throw new InvalidDataException();
                }
                this.WriteSave(contains);
            }
            catch (SystemException)
            {
                throw new InvalidDataException();
            }

        }

        /// <summary>
        /// Write Save 
        /// </summary>
        /// <param name="path"> un conteneur .</param>
        private void WriteSave(Cell[] contains)
        {
            if (File.Exists(this.savePath))
            {
                File.Delete(this.savePath);
            }
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(this.savePath))
            {
                foreach (Cell curr in contains)
                {
                    string tmpExpr = curr.GetExpression().GetData();
                    CellCoord tmpName = curr.Name;
                    sw.WriteLine(tmpName.Ligne + "@" + tmpName.Colonne + "<-" + tmpExpr + ";");
                    //ecriture dans le stream
                }
            }
        }


        /// <summary>
        /// ExportFile qui exporte un fichier en csv
        /// </summary>
        /// <param name="path"> un conteneur et un path.</param>
        public void ExportFile(Cell[] contains, string path)
        {
            try
            {
                if (!path.Equals("empty"))
                {
                    this.exportPath = path;
                }
                else if (this.exportPath.Equals("empty"))
                {
                    throw new InvalidDataException();
                }
                this.WriteExport(contains);
            }
            catch (SystemException)
            {
                throw new InvalidDataException();
            }
        }

        /// <summary>
        /// Write Export
        /// </summary>
        /// <param name="path"> un conteneur de cellule.</param>
        private void WriteExport(Cell[] contains)
        {
            double size = Math.Sqrt(contains.Length);
            double square = Math.Truncate(size);
            if (!File.Exists(this.exportPath))
            {
                File.Delete(this.exportPath);
            }
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(this.exportPath))
            {
                double i = 1;

                foreach (Cell curr in contains)
                {
                    string ligne = "";

                    string tmpExpr = curr.GetExpression().CalculVal();
                    String[] withoutQuote = tmpExpr.Split('"');
                    tmpExpr = "";
                    foreach (String current in withoutQuote)
                    {
                        tmpExpr += current;
                    }
                    ligne += tmpExpr + ",";
                    sw.Write(ligne);

                    if (i == square)
                    {
                        sw.Write(Environment.NewLine);
                        i = 1;
                    }
                    else
                    {
                        i += 1;
                    }
                }
                //ecriture dans le stream
            }
        }

        /// <summary>
        /// Open File
        /// </summary>
        /// <param name="path"> un path.</param>
        public string OpenFile(string path)
        {
            try
            {
                string lines = "";
                string line = "";
                using (StreamReader sr = File.OpenText(path))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        lines += line;
                    }
                }

                return lines;
            }
            catch (SystemException)
            {
                throw new InvalidDataException();
            }
        }

        /// <summary>
        /// Import File
        /// </summary>
        /// <param name="path"> un path.</param>
        public string ImportFile(string path)
        {
            try
            {
                string lines = "";
                using (StreamReader sr = File.OpenText(path))
                {
                    string line = "";
                    int colonne = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        int ligne = 0;
                        string[] tabline = line.Split(',');
                        foreach (string celltmp in tabline)
                        {
                            float tmp;
                            try
                            {
                                tmp = Single.Parse(celltmp);
                                line = ligne + "@" + colonne + "<-" + tmp + ";";
                            }
                            catch (FormatException)
                            {
                                line = ligne + "@" + colonne + "<-" + '"' + celltmp + '"' + ";";
                            }
                            lines += line;
                            colonne++;
                        }
                        ligne++;
                    }
                }
                return lines;
            }
            catch (SystemException)
            {
                throw new InvalidDataException();
            }
        }

        /// <summary>
        /// get Help
        /// </summary>
        /// <param name="path"> .</param>
        public string getHelp()
        {
            string ctt = "";
            using (StreamReader sr = File.OpenText(this.helpPath))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    ctt += line + Environment.NewLine;
                }
            }
            return ctt;
        }

        /// <summary>
        /// les paramettres
        /// </summary>
        private string helpPath;
        private string exportPath;
        private string savePath;
    }
}