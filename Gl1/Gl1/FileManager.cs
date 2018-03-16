using System;
using System.IO;
using Aosk.CellSpace;
using System.Collections.Generic;
using Aosk.Exceptions;

namespace Aosk
{
    /// <summary>
    /// Classe gérant l'interaction avec les fichiers physiques
    /// </summary>
    public class FileManager
    {
        /// <summary>
        /// Constructeur de la classe FileManager
        /// </summary>
        public FileManager()
        {
            this.helpPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDi‌​rectory, "..\\..\\..\\Doc\\help.txt"));
            this.savePath = "empty";
            this.exportPath = "empty";
        }

        /// <summary>
        /// Sauvegarde les donnees dans un format proprietaire
        /// </summary>
        /// <param name="path">Le nom du fichier à enregistrer.</param>
        /// <param name="contains">L'ensemble des cellules a sauvegarder</param>
        /// <see cref="Cell"/> 
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
                    throw new InvalidPathException();
                }
                this.WriteSave(contains);
            }
            catch (SystemException)
            {
                throw new InvalidPathException();
            }

        }
        /// <summary>
        /// Fonction permettant d'ecrire les cellules du container dans le fichier lors de la sauvegarde.
        /// </summary>
        /// <param name="contains">L'ensemble des cellules a enregistrer</param>
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
        /// Sauvegarde l'ensemble des cellules dans un fichier indique par le chemin d'accès dans un format .csv
        /// </summary>
        /// <param name="path">Le nom du fichier.</param>
        /// <param name="contains">L'ensemble des cellules</param>
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
                    throw new InvalidPathException();
                }
                this.WriteExport(contains);
            }
            catch (SystemException)
            {
                throw new InvalidPathException();
            }
        }
        /// <summary>
        /// Fonction permettant d'ecrire les cellules du container dans le fichier lors de l'export.
        /// </summary>
        /// <param name="contains">L'ensemble des cellules a enregistrer</param>
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
        /// Ouvre un fichier au chemin indique
        /// </summary>
        /// <param name="path">Le chemin du fichier a ouvrir.</param>
        /// <returns>Le chemin s'il est valide</returns> 
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
                throw new InvalidPathException();
            }
        }
        /// <summary>
        /// Recupere toutes les cellules d'un fichier specifie.
        /// </summary>
        /// <param name="path">Le nom du fichier.</param>
        /// <returns>La totalite des cellules du fichier</returns>
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
                throw new InvalidPathException();
            }
        }

        /// <summary>
        /// Fonction permettant l'affichage de l'aide
        /// </summary>
        /// <returns>Le texte d'aide</returns>
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
        /// Chemin vers le fichier d'aide
        /// </summary>
        private string helpPath;
        /// <summary>
        /// Chemin vers le fichier d'export
        /// </summary>
        private string exportPath;
        /// <summary>
        /// Chemin vers le fichier de sauvegarde
        /// </summary>
        private string savePath;
    }
}