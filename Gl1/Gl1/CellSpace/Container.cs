using Aosk.Exceptions;
using System.Collections.Generic;

namespace Aosk.CellSpace
{
    /// <summary>
    ///     Classe contenant une collection de cellules et les manipule.
    /// </summary>
    public class Container
    {
        /// <summary>
        /// Constructeur de Container.
        /// Instancie la collection.
        /// </summary>
        public Container()
        {
            this.cells = new Dictionary<CellCoord, Cell>();
        }
        /// <summary>
        /// Ajoute une cellule dans le container.
        /// </summary>
        /// <param name="cellule">La cellule a ajouter dans la collection</param>
        public void AddCell(Cell cellule)
        {
            this.cells.Add(cellule.Name, cellule);
        }
        /// <summary>
        /// Supprime une cellule dans le container
        /// </summary>
        /// <param name="cellule">La cellule à supprimer dans la collection</param>
        public void DeleteCell(Cell cellule)
        {
            this.cells.Remove(cellule.Name);
        }
        /// <summary>
        /// Recherche une cellule dans le container
        /// </summary>
        /// <param name="cellName">La cle de la cellule à chercher et à renvoyer si elle existe</param>
        /// <returns>La cellule cherchee si elle est trouvee</returns>
        public Cell SearchCell(CellCoord cellName)
        {
            if (this.ExisteCell(cellName))
            {
                return cells[cellName];
            }
            else throw new CellNotFoundException();
        }
        /// <summary>
        /// Renvoie un tableau contenant l'ensemble des cellules du container
        /// </summary>
        /// <returns>Le tableau de cellule</returns>
        public Cell[] Cells
        {
            get
            {
                Cell[] cells = new Cell[this.cells.Count];
                this.cells.Values.CopyTo(cells, 0);
                return cells;
            }
        }
        /// <summary>
        /// Permet de verifier si une cellule est cree ou non dans le container
        /// </summary>
        /// <param name="cellName">La cle de la cellule cherchee</param>
        /// <returns>Vrai si la cellule est contenue dans le container, Faux sinon</returns>
        public bool ExisteCell(CellCoord cellName)
        {
            return this.cells.ContainsKey(cellName);
        }
        /// <summary>
        /// La collection du container contenant les cellules
        /// </summary>
        private Dictionary<CellCoord, Cell> cells;
    }
}