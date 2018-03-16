using System;
using Aosk.CellSpace;
using Aosk;
using Aosk.ParserSpace;
using Aosk.Exceptions;
using Aosk.TermSpace;

/// <summary>
/// Classe possedant le conteneur de cellules et permettant de manipuler ces dernieres.
/// </summary>
public class Kernel
{
    /// <summary>
    /// Constructeur de la classe Kernel, initialisation de ses attributs
    /// </summary>
    public Kernel()
    {
        container = new Container();
        fileManager = new FileManager();
        parser = new Parser(this);
    }
    /// <summary>
    /// Fonction 
    /// </summary>
    /// <param name="toAnalyze">Chaine de caracteres a analyser</param>
    /// <returns>Chaine de caracteres pour le traitement si valide</returns>
    public string interact(string toAnalyze)
    {
        try
        {
            string result = this.parser.Analyse(toAnalyze);
            String[] withoutQuote = result.Split('"');
            result = "";
            foreach (string curr in withoutQuote)
            {
                result += curr;
            }
            return result;
        }
        catch (AoskException e)
        {
            string res = e.Message + Environment.NewLine;
            res += "Use help to more informations";
            return res;
        }
    }

    /// <summary>
    /// Insere la valeur dans la cellule cible
    /// </summary>
    /// <param name="target">Nom de la cellule a modifier.</param>
    /// <param name="val">Donnees a inserer.</param>
    public void InsertData(CellCoord target, Term val)
    {
        if (container.ExisteCell(target))
        {
            container.SearchCell(target).Write(new Expression(val));
        }
        else
        {
            Cell c = new Cell(target, new Expression(val));
            container.AddCell(c);
        }
    }
    /// <summary>
    /// Copie le contenu d'une cellule dans une autre 
    /// </summary>
    /// <param name="target">Nom de la cellule cible.</param>
    /// <param name="toCopy">Nom de la cellule d'origine.</param>
    public void CopyData(CellCoord target, CellCoord toCopy)
    {
        Cell c2 = container.SearchCell(toCopy);
        Expression expr = c2.GetExpression();
        if (this.container.ExisteCell(target))
        {
            Cell c1 = container.SearchCell(target);
            c1.Write(expr);
        }
        else
        {
            Cell c1 = new Cell(target, expr);
            this.container.AddCell(c1);
        }

    }
    /// <summary>
    /// Affiche la valeur de la cellule nommee
    /// </summary>
    /// <param name="target">Nom de la cellule a afficher.</param>
    /// <returns>La valeur de la cellule</returns>
    public String Read(CellCoord target)
    {
        Cell cell = container.SearchCell(target);
        if (cell != null)
        {
            return cell.GetExpression().CalculVal();
        }
        else
        {
            throw new Exception("Cell not created");
        }
    }
    /// <summary>
    /// Supprime le contenu de la cellule nommee 
    /// </summary>
    /// <param name="target">Nom de la cellule dont le contenu doit etre supprimer.</param>
    public void DeleteContent(CellCoord target)
    {
        Cell cell = container.SearchCell(target);
        cell.CleanCell();
        container.DeleteCell(cell);
    }
    /// <summary>
    /// copie le contenu de la cellule nomm�e (target), de cette cellule a la cellule nomm�e (toPropage), ou cr�er ces cellules si elles n'existent pas
    /// </summary>
    /// <param name="target">Nom de la cellule qui va �tre modifi�.</param>
    /// <param name="toPropage">Nom de la cellule � propager.</param>
    public void Propage(CellCoord target, CellCoord toPropage)
    {
        ulong depCol = Math.Min(target.Colonne, toPropage.Colonne);
        ulong depLine = Math.Min(target.Ligne, toPropage.Ligne);
        ulong destCol = Math.Max(target.Colonne, toPropage.Colonne);
        ulong destLine = Math.Max(target.Ligne, toPropage.Ligne);

        for (ulong i = depLine; i <= destLine; i++)
        {
            for (ulong j = depCol; j <= destCol; j++)
            {
                CellCoord curr = new CellCoord(i, j);
                this.CopyData(curr, toPropage);
            }
        }
    }
    /// <summary>
    /// Ouverture de fichier
    /// </summary>
    /// <param name="path">Le chemin vers le fichier a ouvrir</param>
    public void Open(string path)
    {
        this.parser.Analyse(this.fileManager.OpenFile(path));
    }
    /// <summary>
    /// Sauvegarde de fichier
    /// </summary>
    /// <param name="path">Le chemin vers le fichier cible</param>
    public void Save(string path = "empty")
    {
        Cell[] cells = this.container.Cells;
        fileManager.SaveFile(cells, path);

    }
    /// <summary>
    /// Importe les donnees d'un fichier
    /// </summary>
    /// <param name="path">Fichier dont on veut recuperer les donnees</param>
    public void Import(string path)
    {
        this.parser.Analyse(fileManager.ImportFile(path));
    }
    /// <summary>
    /// Exporte les donnees d'un fichier 
    /// </summary>
    /// <param name="path">Le chemin vers le fichier cible</param>
    public void Export(string path = "empty")
    {
        Cell[] cells = this.container.Cells;
        fileManager.ExportFile(cells, path);
    }
    /// <summary>
    /// Recherche une cellule dans le container
    /// </summary>
    /// <param name="target">La cle de la cellule a chercher</param>
    /// <returns>La cellule si elle est trouvee</returns>
    public Cell searchCell(CellCoord target)
    {
        Cell cell = container.SearchCell(target);
        if (cell != null)
        {
            return cell;
        }
        else
        {
            throw new Exception("Cell not created");
        }
    }
    /// <summary>
    /// Fonction permettant l'affichage de l'aide
    /// </summary>
    /// <returns>Le texte d'aide</returns>
    public string help()
    {
        return this.fileManager.getHelp();
    }
    /// <summary>
    /// Attribut contenant toutes les cellules
    /// </summary>
    /// <see cref="Container"/>
    private Container container;
    /// <summary>
    /// Attribut de gestion de fichiers
    /// </summary>
    /// <see cref="FileManager"/>
    private FileManager fileManager;
    /// <summary>
    /// Attribut permettant de gerer les commandes utilisateurs
    /// </summary>
    /// <see cref="Parser"/>
    private Parser parser;

}
